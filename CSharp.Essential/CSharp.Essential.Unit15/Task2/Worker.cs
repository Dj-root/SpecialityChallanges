using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit15
{
    class WorkerClass
    {
        struct Worker
        {
            string firstName;
            string lastName;
            string position;
            DateTime hireDate;

            public Worker(string fname, string lname, string pos, string hdate)
            {
                this.firstName = fname;
                this.lastName = lname;
                this.position = pos;

                // Sorry for smelling code
                string fullDate = hdate + ".01.01 00:00:00";

                try
                {
                    DateTime dt = DateTime.Parse(fullDate);
                    this.hireDate = dt;
                }
                catch (FormatException e)
                {
                    throw;
                }

            }

            public override string ToString()
            {
                int years = DateTime.Now.Year - hireDate.Year;

                return string.Format("Worker name: {0} {1} \nPosition: {2} \nworks from {3:yyyy} during {4} years",
                    this.firstName, this.lastName, this.position, hireDate, years);
            }

            public DateTime HireDate { get { return hireDate; } }
            public string FirstName { get { return firstName; } }
            public string LastName { get { return lastName; } }
        }

        private Worker[] workers = new Worker[5];

        public void FillWorkers()
        {
            Console.WriteLine("We need to type information about {0} workers", workers.Length);

            for (int i = 0; i < workers.Length; i++)
            {
                try
                {
                    workers[i] = FillWorker();
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Incorrect date type. Try again");
                    i--;
                }
            }
        }

        public void AutoFillWorkers()
        {
            Console.WriteLine("We need to type information about {0} workers", workers.Length);

            workers[0] = new Worker("Ivanov", "Ivan", "QA", "2016");
            workers[1] = new Worker("Petrov", "Petr", "Developer", "2007");
            workers[2] = new Worker("Borisov", "Boris", "TeamLead", "2011");
            workers[3] = new Worker("Adams", "Brian", "ISO", "2006");
            workers[4] = new Worker("Murka", "Masha", "QA", "2012");

        }

        public void ShowWorkers()
        {
            Console.WriteLine("List of workers:");

            foreach (Worker wk in workers)
            {
                Console.WriteLine(wk);
                Console.WriteLine(new String('~', 50));
            }
        }

        private Worker FillWorker()
        {
            //string firstName = "Ivan";
            //string lastName = "Ivanov";
            //string position = "UI";
            //string hireDate = "2015";

            string firstName = "Ivan";
            string lastName = "Ivanov";
            string position = "UI";
            string hireDate = "2015";

            Console.WriteLine("Type info about worker:");
            Console.Write("First name: ");
            firstName = Console.ReadLine();

            Console.Write("Last name: ");
            lastName = Console.ReadLine();

            Console.Write("Position name: ");
            position = Console.ReadLine();

            Console.Write("Year of hiring: ");
            hireDate = Console.ReadLine();
            try
            {
                return new Worker(firstName, lastName, position, hireDate);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Somethig happens");
                Console.WriteLine(e.GetType());
                throw;
            }
        }

        public bool SortWorkers()
        {
            Worker[] sortedWorkers = SortByAsc(workers);

            try
            {
                this.workers = sortedWorkers;
            }
            catch (Exception)
            {

                return false;
            }

            return true;

        }
        #region Sorting Algorithm

        private static Worker[] SortByAsc(Worker[] srcWorkers)
        {

            Worker[] sortedWorkers = srcWorkers;
            QuickSort(ref sortedWorkers, 0, sortedWorkers.Length - 1);

            return sortedWorkers;
        }

        //        Using Quick Sort method

        static void QuickSort(ref Worker[] srcWorkers, int loIdx, int hiIdx)
        {
            int splitPoint;
            if (loIdx < hiIdx)
            {
                splitPoint = Partition(ref srcWorkers, loIdx, hiIdx);
                QuickSort(ref srcWorkers, loIdx, splitPoint);
                QuickSort(ref srcWorkers, splitPoint + 1, hiIdx);
            }
        }

        static int Partition(ref Worker[] srcWorkers, int loIdx, int hiIdx)
        {
            Worker pivot = srcWorkers[loIdx];
            int left, right, rslt;
            Worker swap, tmp;

            left = loIdx - 1;
            right = hiIdx + 1;

            while (true)
            {
                do
                {
                    left++;
                    tmp = srcWorkers[left];
                    rslt = tmp.FirstName.CompareTo(pivot.FirstName);
                } while (rslt < 0);

                do
                {
                    right--;
                    tmp = srcWorkers[right];
                    rslt = tmp.FirstName.CompareTo(pivot.FirstName);
                } while (rslt > 0);

                if (left >= right)
                {
                    return right;
                }

                swap = srcWorkers[left];
                srcWorkers[left] = srcWorkers[right];
                srcWorkers[right] = swap;
            }
        }

        #endregion

        private Worker[] FindWorkerByPeriod(int period)
        {
            int exp, position = -1;
            //int 
            Worker[] foudWorkers = new Worker[workers.Length];

            foreach (Worker wrk in workers)
            {
                exp = DateTime.Now.Year - wrk.HireDate.Year;
                if (exp > period)
                {
                    foudWorkers[++position] = wrk;
                }
            }

            if (position == -1)
            {
                return null;
            }
            else
            {
                return ResizeArray(foudWorkers, ++position);
            }
        }

        private Worker[] ResizeArray(Worker[] array, int size)
        {
            int i;
            Worker[] tmp = new Worker[size];

            if (array.Length < size)
            {
                i = array.Length - 1;
            }
            else
            {
                i = tmp.Length - 1;
            }


            for (i = 0; i < tmp.Length; i++)
            {
                tmp[i] = array[i];
            }

            return tmp;
        }

        public void SearchWorkerByExp()
        {
            int exp;
            Worker[] foundWorkers;

            Console.Write("\nType experience criteria for search: ");

            try
            {
                exp = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetType());
                Console.WriteLine("Cannot convert typed text into exp. Try again");
                return;
            }

            foundWorkers = FindWorkerByPeriod(exp);

            if (foundWorkers == null)
            {
                Console.WriteLine("No workers found with {0} years experience", exp);
            }
            else
            {
                PrintWorkerInfo(foundWorkers);
            }
        }

        private void PrintWorkerInfo(Worker[] wrk)
        {
            Console.WriteLine("\nFound workers list:");
            foreach (var item in wrk)
            {
                Console.WriteLine("First name: {0}, Last Name: {1}", item.FirstName, item.LastName);
            }
        }

    }
}
