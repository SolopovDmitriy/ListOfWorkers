using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Manager : Employee, IManage
    {
        private ListOfWorkers _workers; //список рабочих текущего экземпляра менеджера
        public ListOfWorkers Workers { //поле получения доступа к рабочим текущего менеджера
            get
            {
                return _workers;
            }
        }
        
        public IWorker GetWorker(int index)
        {
            return _workers.GetWorker(index);
        }

        public IWorker GetWorker(string workDescription)
        {
            for (int i = 0; i <= _workers.Count; i++)
            {
                if (_workers.GetWorker(i).Work() == workDescription)
                {
                    return _workers.GetWorker(i);
                }
            }
            return null;
        }

        public void PushWork(string task, IWorker[] workers)
        {
            for (int i = 0; i <= _workers.Count; i++)
            {
                if (_workers.GetWorker(i).IsWorking == false)
                {
                    _workers.GetWorker(i).NextTask(task);
                    return;
                }
            }
        }
        public Manager()
        {
            _workers = new ListOfWorkers();
        }
















        public void Control()
        {
            throw new NotImplementedException();
        }

        public void Organize()
        {
            throw new NotImplementedException();
        }
    }
}
