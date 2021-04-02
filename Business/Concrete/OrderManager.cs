using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
	public class OrderManager : IOrderService
	{
		IOrderDal _orderDal;

		public OrderManager(IOrderDal orderDal)
		{
			_orderDal = orderDal;
		}

		public IResult Add(Order order)
		{
			_orderDal.Add(order);
			return new SuccessResult("Sipariş eklendi");
		}

		public IResult Delete(Order order)
		{
			_orderDal.Delete(order);
			return new SuccessResult("Sipariş silindi");
		}

		public IDataResult<List<Order>> GetAll()
		{
			return new SuccessDataResult<List<Order>>(_orderDal.GetAll());
		}

		public IDataResult<Order> GetById(int orderId)
		{
			return new SuccessDataResult<Order>(_orderDal.Get(o => o.OrderId == orderId));
		}

		public IResult Update(Order order)
		{
			_orderDal.Update(order);
			return new SuccessResult("Sipariş güncellendi");
		}
	}
}
