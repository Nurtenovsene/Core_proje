
using DataAcessLayor.Concrete;
using DataAcessLayor.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessLayor.Repository;
using EntityLayer.Concrete;

namespace DataAcessLayor.EntityFramework
{
    public class EfTestimonialDal : GenericRepository  <Testimonial>,ITestimonialDal

    {
    }
}


