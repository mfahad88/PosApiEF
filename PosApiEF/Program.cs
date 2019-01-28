using PosApiEF.Entities;
using PosApiEF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosApiEF
{
    class Program
    {
        static void Main(string[] args)
        {
            dofactoryEntities context = new dofactoryEntities();
            var repo = new GenericRepository<Customer>(context);
            List<Customer> list = repo.GetAll().ToList();
            foreach (var item in list)
            {
                Console.WriteLine(item.Id);
            }
            Console.ReadLine();
        }
    }
}
