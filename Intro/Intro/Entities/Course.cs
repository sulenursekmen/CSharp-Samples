using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Entities;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    // prop ile hızlı oluştur
    public double Price { get; set; }
}
