using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class ListOfWorkers
    {
        private int _counter = 0; //количество занятых элементов
        private int _capacity = 8;  // константа 
        private int _currentCapacity = 0; //количество ячеек в массива - стартовое
        private IWorker[] _workers; //массив - список сотрудников
        private enum ChoiseResize
        {
            UP,
            DOWN
        }
        public int Count
        {
            get
            {
                return _counter;
            }
        }

        public ListOfWorkers()
        {
            _currentCapacity = _capacity;
            _workers = new IWorker[_currentCapacity];
        }

        public void AddWorker(IWorker worker)
        {
            if (_counter == _currentCapacity) //мест нет
            {
                Resize(ChoiseResize.UP);
            }
            _workers[_counter] = worker;
            _counter++;
        }

        public int SearchWorker(IWorker worker)
        {
            int delIndex = -1;
            for (int i = 0; i < _counter; i++)
            {
                if (_workers[i] == worker)
                {
                    delIndex = i;
                    break;
                }
            }
            return delIndex; //return -1 если не найден
        }


        public IWorker GetWorker(int index)
        {
            if(index >=0 && index < _counter)
            {
                return _workers[index];
            }
            throw new IndexOutOfRangeException();           
        }

        public void RemoveWorker(IWorker worker)
        {
            int ind = SearchWorker(worker);
            if (ind == -1) throw new ArgumentOutOfRangeException("");

            for (int i = ind; i < _counter - 1; i++)
            {
                _workers[i] = _workers[i + 1];
            }
            _workers[_counter - 1] = null;
            _counter--;

            // _counter = 64 -- количество рабочих 
            // _currentCapacity = 80 -- количество ячеек в массиве
            // _capacity = 8 -- всегда равно 8, константа 
            if (_counter + _capacity - 1 < _currentCapacity - _capacity) //  64 + 8 - 1 < 80 - 8      71<72
            {
                Resize(ChoiseResize.DOWN);
            } else if(_counter == 0)
            {
                return;
            }
        }
        public IWorker[] Workers
        {
            get
            {
                return _workers;
            }
        }
        //listOfWorkers.RemoveWorker(listOfWorkers.Workers[0]);
        private void Resize(ChoiseResize resize)
        {
            IWorker[] tmp;
            switch (resize)
            {
                case ChoiseResize.UP:
                    {
                        _currentCapacity += _capacity;   //  _currentCapacity =_currentCapacity + _capacity = 80 + 8 = 88
                        break;
                    }
                case ChoiseResize.DOWN:
                    {
                        if (_currentCapacity == _capacity) break;
                        // _counter = 71 -- количество рабочих 
                        // _currentCapacity = 80 -- количество ячеек в массиве
                        // _capacity = 8 -- всегда равно 8, константа 
                        if (_counter < _currentCapacity - _capacity)  // 71 < 80 - 8
                        {
                            _currentCapacity -= _capacity;  //  _currentCapacity =_currentCapacity - _capacity = 80 - 8 = 72
                        }
                        else if(_counter > _currentCapacity)
                        {
                            throw new ArgumentOutOfRangeException("Неконтролируемое перераспределение");
                        }
                        break;
                    }
            }
            tmp = new IWorker[_currentCapacity];
            for (int i = 0; i < _counter; i++)
            {
                tmp[i] = _workers[i];
            }
            _workers = tmp;
        }





    }
}
