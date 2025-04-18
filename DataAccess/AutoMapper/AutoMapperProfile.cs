﻿using AutoMapper;
using Domain.Entities;
using Domain.ViewModel.Cart;
using Domain.ViewModel.Category;
using Domain.ViewModel.Order;
using Domain.ViewModel.ProductReview;
using Domain.ViewModel.User;
using Microsoft.AspNetCore.Identity;

namespace DataAccess.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<IdentityRole<Guid>, Role>();
            CreateMap<User, UserDto>();
            CreateMap<ManageProductInCartDto, ProductCart>();
            CreateMap<ProductReviewRequest, ProductReview>();
            CreateMap<OrderAddDto, Order>();
            CreateMap<OrderUpdateRequest, Order>();
            CreateMap<OrderDetailDto, OrderDetail>();
            CreateMap<OrderDetailReq, OrderDetail>();
            CreateMap<OrderDetail, OrderDetailDto>();
            CreateMap<OrderStatusHistoryDto, OrderStatusHistory>();
            CreateMap<ShippingInfoDto, ShippingInfor>();
            CreateMap<ShippingInfor, ShippingInfoDto>();
            CreateMap<UpdateUserRequest, User>();
            CreateMap<Category, CategoryDto>();
        }
    }
}
