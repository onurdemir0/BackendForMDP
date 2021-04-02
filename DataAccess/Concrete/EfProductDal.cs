using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete
{
	public class EfProductDal : EfEntityRepositoryBase<Product, MdpContext>, IProductDal
	{
		public List<ProductDetailDto> GetProductDetails()
		{
			using (MdpContext context = new MdpContext())
			{
				var result = from p in context.Products
							 join c in context.Categories
							 on p.CategoryId equals c.CategoryId
							 select new ProductDetailDto
							 {
								 ProductId = p.ProductId,
								 ProductName = p.ProductName,
								 CategoryName = c.CategoryName,
								 UnitsInStock = p.UnitsInStock,
								 UnitPrice = p.UnitPrice
							 };
				return result.ToList();
			}
		}
	}
}
