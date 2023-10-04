using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt_1_6
{
    public class Mamal
    {

        public void Grow() { }
        public void Eat() { }
        public void Reproduce() { }
    }
    public class Whale : Mamal
    {

    }

    public interface IThinking
    {
        void thinking_behavior();
    }
    public interface IIntelligent
    {
        void intelligent_behavior();
    }
    public interface IAbility : IThinking, IIntelligent
    {
    }
    public class Human : Mamal, IAbility
    {
        public void intelligent_behavior()
        {

        }
        public void thinking_behavior()
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
