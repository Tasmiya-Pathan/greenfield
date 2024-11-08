using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Specification;
using POCOLib;
namespace BinaryRepositoryLib
{
    public class BinaryReopsitory: IDataRepository
    {
        public bool Serialize(string filename, List<Product> products)
        {
            bool status = false;
            //code for saving
            BinaryFormatter formatter = new BinaryFormatter();            //creating formatter object
            FileStream stream = new FileStream(filename, FileMode.OpenOrCreate);     //creating stream object
            formatter.Serialize(stream, products);                 // (what to and where to serialize)
            stream.Close();
            return status;
        }
        public List<Product> Deserialize(string filename)
        {
            List<Product> products = new List<Product>();

            //retrieve all products from file
            FileStream stream = new FileStream(filename, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            if(stream!=null)
            {
                products =(List<Product>) formatter.Deserialize(stream);
            }
            stream.Close();
            return products;
        }
    }
}
