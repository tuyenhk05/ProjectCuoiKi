﻿using ClassLibrary.Repositorries.Entities;
using ClassLibrary.Repositorries.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Repositorries.Repositorries
{
    public class OrderDetailRepositorries: IOrderDetailRepositorries
    {
        private readonly QuanliwedContext _dbContext;
        public OrderDetailRepositorries(QuanliwedContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<OrderDetail>> GetOrderDetail()
        {
            return await _dbContext.OrderDetail.ToListAsync();
        }
        public int AddOrderDetail(OrderDetailorderDetailId)
        {
            throw new NotImplementedException();
        }

        public bool DelOrderDetail(int orderDetailId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<OrderDetail>> GetOrderDetail()
        {
            List<OrderDetail>? orderDetail = null;
            try
            {
                orderDetail = await _dbContext.OrderDetail.ToListAsync();
            }
            catch (Exception ex)
            {
                orderDetail?.Add(new OrderDetail());
            }

            return orderDetail;
        }

        public async Task<IList<OrderDetail>> ToListAsync()
        {
            return await _dbContext.OrderDetail.ToListAsync();
        }


    }