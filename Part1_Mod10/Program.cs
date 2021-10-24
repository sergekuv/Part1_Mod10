using System;

namespace Part1_Mod10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task_10_1_4();
            //Task_10_2_2();
            //Task_10_2_3();
            //Task_10_3_1();
            //Task_10_3_2();
            //Task_10_3_3();
            //Task_10_4();
            //Task_10_1_40_4_4();
            Console.WriteLine("-- end --");
        }
        #region Task 10.4.4
        private static void Task_10_1_40_4_4()
        {
            User u = new();
            Account a = new();

            //IUpdater<Account> updater = new UserService();
            
            UserService us = new UserService();
            us.Update(u);
            us.Update(a);

        }

        public interface IUpdater<in T>
        {
            void Update(T entity);
        }
        class UserService : IUpdater<User>
        {
            public void Update(User entity)
            {
                Console.WriteLine($"{entity} updated");
            }
        }
        public class User
        {

        }

        public class Account : User
        {

        }
        #endregion

        #region Task 10.4
        private static void Task_10_4()
        {
            IMessenger<Phone> viberInPhone = new Viber<Phone>();
            IMessenger<IPhone> viberInIPhone = new Viber<IPhone>();

            viberInPhone.DeviceInfo();
            viberInIPhone.DeviceInfo();


            Console.Read();
        }
        public class Viber<T> : IMessenger<T> where T : Phone, new()
        {
            public T DeviceInfo()
            {
                T device = new T();
                Console.WriteLine(device);
                return new T();
            }
        }

        public interface IMessenger <T>
        {
            T DeviceInfo();
        }
        public class Phone { }
        public class IPhone : Phone { }
        public class Computer { }
        #endregion


        #region Task 10.3.3
        private static void Task_10_3_3()
        {
            throw new NotImplementedException();
        }
        class ElectronicBook : IBook, IDevice
        {
            void IBook.Read()
            {
                throw new NotImplementedException();
            }

            void IDevice.TurnOff()
            {
                throw new NotImplementedException();
            }

            void IDevice.TurnOn()
            {
                throw new NotImplementedException();
            }
        }
        public interface IBook
        {
            void Read();
        }
        public interface IDevice
        {
            void TurnOn();
            void TurnOff();
        }
        #endregion
        #region Task 10.3.2
        private static void Task_10_3_2()
        {
            throw new NotImplementedException();
        }
        class Entity : ICreatable, IUpdatable, IDeletable
        {
            public void Create()
            {
                throw new NotImplementedException();
            }

            public void Delete()
            {
                throw new NotImplementedException();
            }

            public void Update()
            {
                throw new NotImplementedException();
            }
        }
        public interface ICreatable
        {
            void Create();
        }
        public interface IDeletable
        {
            void Delete();
        }
        public interface IUpdatable
        {
            void Update();
        }

        #endregion
        #region Task 10.3.1
        private static void Task_10_3_1()
        {
            throw new NotImplementedException();
        }

        class FileManager : IReader, IWriter, IMailer
        {
            public void Read()
            {
                throw new NotImplementedException();
            }

            public void SendEmail()
            {
                throw new NotImplementedException();
            }

            public void Write()
            {
                throw new NotImplementedException();
            }
        }
        public interface IWriter
        {
            void Write();
        }

        public interface IReader
        {
            void Read();
        }

        public interface IMailer
        {
            void SendEmail();
        }
        #endregion
        #region Task 10.2.3
        private static void Task_10_2_3()
        {
            Worker worker = new();
            worker.Build();
            ((IWorker)worker).Build();
        }

        public class Worker : IWorker
        {
            public void Build()
            {
                Console.WriteLine("worker Build");
            }
            void IWorker.Build()
            {
                Console.WriteLine("-- Iworker Build");
            }
        }

        public interface IWorker
        {
            internal void Build();
        }
        #endregion
        #region Task 10.2.2
        private static void Task_10_2_2()
        {
            throw new NotImplementedException();
        }
        private class Writer : IWriter
        {
            public void Write()
            {
                throw new NotImplementedException();
            }

            void IWriter.Write()
            {
                throw new NotImplementedException();
            }
        }

        #endregion
        #region Task 10.1.4
        private static void Task_10_1_4()
        {
            throw new NotImplementedException();
        }

        public interface IManager
        {
            void Create();
            void Read();
            public void Update();
            public void Delete();
        }

        public class Manager : IManager
        {
            public void Create()
            {

            }

            public void Read()
            {

            }

            public void Update()
            {

            }

            public void Delete()
            {

            }
        }
        #endregion
    }

}
