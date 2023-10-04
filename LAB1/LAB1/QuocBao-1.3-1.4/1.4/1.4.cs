using System;
using System.Threading;

// Lớp chứa thông tin về sự kiện thay đổi nhiệt độ
class TemperatureChangedEventArgs : EventArgs
{
    public double NewTemperature { get; }

    public TemperatureChangedEventArgs(double newTemperature)
    {
        NewTemperature = newTemperature;
    }
}

// Định nghĩa lớp NhiệtKế
class NhiệtKế
{
    private double temperature;
    public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

    public double Temperature
    {
        get { return temperature; }
        set
        {
            if (value != temperature)
            {
                temperature = value;
                OnTemperatureChanged(new TemperatureChangedEventArgs(value));
            }
        }
    }

    protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
    {
        TemperatureChanged?.Invoke(this, e);
    }
}

// Lớp màn hình hiển thị nhiệt độ của nhiệt kế
class MànHìnhHiểnThị
{
    public void HiểnThịNhiệtĐộ(object sender, TemperatureChangedEventArgs e)
    {
        Console.WriteLine($"Nhiệt độ mới: {e.NewTemperature} °C");
    }
}

class Program
{
    static void Main()
    {
        NhiệtKế nhiệtKế = new NhiệtKế();
        MànHìnhHiểnThị mànHình = new MànHìnhHiểnThị();

        // Đăng ký sự kiện TemperatureChanged
        nhiệtKế.TemperatureChanged += mànHình.HiểnThịNhiệtĐộ;

        // Giả lập việc thay đổi nhiệt độ ngẫu nhiên và thông báo sự kiện
        Random random = new Random();
        for (int i = 0; i < 5; i++)
        {
            double newTemperature = random.Next(0, 100);
            nhiệtKế.Temperature = newTemperature;
            Thread.Sleep(1000); // Đợi 1 giây trước khi thay đổi nhiệt độ tiếp theo
        }
    }
}
