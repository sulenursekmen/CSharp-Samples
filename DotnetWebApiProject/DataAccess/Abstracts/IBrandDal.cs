using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts;

//DAL Data Access Layer
public interface IBrandDal
{
    void Add(Brand brand);
    List<Brand> GetAll();

}
