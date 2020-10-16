using System;
using System.Collections.Generic;
using System.Text;

namespace YuceEgitim.Services
{
    public class CounterService : ICounterService
    {
        private readonly List<int> _myList;
        private readonly object lockobj = new Object();

        public CounterService()
        {
            //threadsafe collection
            // lock
            _myList = new List<int>() { 1, 2, 3 };
        }
        public IEnumerable<int> GetMyList()
        {
            return _myList;
        }

        public void AddToMyList(int deger)
        {
            lock(lockobj){ _myList.Add(deger); }
            
        }
    }

    public interface ICounterService
    {
        IEnumerable<int> GetMyList();
        void AddToMyList(int deger);
    }
}
