using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN
{
     public class quanLyXe
    {
        public List<Xe> DocFileCSV(string path)
        {
            var dsXe = new List<Xe>();
            bool boQuaTieuDe = true;


            foreach (var line in File.ReadLines(path))
            {


                if (boQuaTieuDe)
                {
                    boQuaTieuDe = false;
                    continue;
                }

                if (string.IsNullOrWhiteSpace(line)) continue;

               
                var parts = line.Split(',');

                var xe = new Xe
                {
                    Id = int.Parse(parts[0]),
                    Manufacturer = parts[1],
                    Model = parts[2],
                    Engine_size = double.Parse(parts[3]),
                    Fuel_type = parts[4],
                    Year_of_manufacture = int.Parse(parts[5]),
                    Mileage = int.Parse(parts[6]),
                    Price = int.Parse(parts[7])                                     
                };
                dsXe.Add(xe);
            }

            return dsXe;
        }


        public void GhiFileCSV(string path, List<Xe> dsXe)
        {
            using (var writer = new StreamWriter(path))
            { 
                writer.WriteLine("id,Manufacturer,Model,Engine_size,Fuel_type,Year_of_manufacture,Mileage,Price");

                foreach (var xe in dsXe)
                {
                    writer.WriteLine($"{xe.Id},{xe.Manufacturer},{xe.Model},{xe.Engine_size},{xe.Fuel_type},{xe.Year_of_manufacture},{xe.Mileage},{xe.Price}");
                }
            }
        }
    }
}
