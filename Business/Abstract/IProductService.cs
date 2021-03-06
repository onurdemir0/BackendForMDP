using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface IProductService
	{
		IDataResult<List<Product>> GetAll();
		IDataResult<List<ProductDetailDto>> GetProductDetails();
		IDataResult<Product> GetById(int productId);
		IResult Add(Product product);
		IResult Update(Product product);
		IResult Delete(Product product);
	}
}
