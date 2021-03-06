using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http;
using AutoMapper;
using BikeShop.Domain;

namespace yourdevpro.Rest.v1
{
	// Generated 10/27/2016 21:38:15
	
	// Add custom code here

	public class BaseApiController : ApiController
	{
		static bool initialized = false;

		static BaseApiController()
		{
			if (!initialized)
			{
                Mapper.CreateMap<Cart, ApiCart>().ForMember(dest => dest.Href, opt => opt.MapFrom(src => src.Id.ToCartHref()));
                Mapper.CreateMap<CartItem, ApiCartItem>().ForMember(dest => dest.Href, opt => opt.MapFrom(src => src.Id.ToCartItemHref()));
                Mapper.CreateMap<Category, ApiCategory>().ForMember(dest => dest.Href, opt => opt.MapFrom(src => src.Id.ToCategoryHref()));
                Mapper.CreateMap<Error, ApiError>().ForMember(dest => dest.Href, opt => opt.MapFrom(src => src.Id.ToErrorHref()));
                Mapper.CreateMap<Order, ApiOrder>().ForMember(dest => dest.Href, opt => opt.MapFrom(src => src.Id.ToOrderHref()));
                Mapper.CreateMap<OrderDetail, ApiOrderDetail>().ForMember(dest => dest.Href, opt => opt.MapFrom(src => src.Id.ToOrderDetailHref()));
                Mapper.CreateMap<OrderNumber, ApiOrderNumber>().ForMember(dest => dest.Href, opt => opt.MapFrom(src => src.Id.ToOrderNumberHref()));
                Mapper.CreateMap<Product, ApiProduct>().ForMember(dest => dest.Href, opt => opt.MapFrom(src => src.Id.ToProductHref()));
                Mapper.CreateMap<Rating, ApiRating>().ForMember(dest => dest.Href, opt => opt.MapFrom(src => src.Id.ToRatingHref()));
                Mapper.CreateMap<User, ApiUser>().ForMember(dest => dest.Href, opt => opt.MapFrom(src => src.Id.ToUserHref()));
                Mapper.CreateMap<Vendor, ApiVendor>().ForMember(dest => dest.Href, opt => opt.MapFrom(src => src.Id.ToVendorHref()));

                Mapper.CreateMap<ApiCart, Cart>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Href.ToId()));
                Mapper.CreateMap<ApiCartItem, CartItem>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Href.ToId()));
                Mapper.CreateMap<ApiCategory, Category>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Href.ToId()));
                Mapper.CreateMap<ApiError, Error>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Href.ToId()));
                Mapper.CreateMap<ApiOrder, Order>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Href.ToId()));
                Mapper.CreateMap<ApiOrderDetail, OrderDetail>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Href.ToId()));
                Mapper.CreateMap<ApiOrderNumber, OrderNumber>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Href.ToId()));
                Mapper.CreateMap<ApiProduct, Product>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Href.ToId()));
                Mapper.CreateMap<ApiRating, Rating>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Href.ToId()));
                Mapper.CreateMap<ApiUser, User>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Href.ToId()));
                Mapper.CreateMap<ApiVendor, Vendor>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Href.ToId()));

				initialized = true;
			}
		}
	}

	// extension methods
	public static class HrefHelper
	{
		static string root = "http://localhost:45871/api/v1/";

        public static string ToCartHref(this int? id) { return root + "carts/" + id; }
        public static string ToCartItemHref(this int? id) { return root + "cartitems/" + id; }
        public static string ToCategoryHref(this int? id) { return root + "categories/" + id; }
        public static string ToErrorHref(this int? id) { return root + "errors/" + id; }
        public static string ToOrderHref(this int? id) { return root + "orders/" + id; }
        public static string ToOrderDetailHref(this int? id) { return root + "orderdetails/" + id; }
        public static string ToOrderNumberHref(this int? id) { return root + "ordernumbers/" + id; }
        public static string ToProductHref(this int? id) { return root + "products/" + id; }
        public static string ToRatingHref(this int? id) { return root + "ratings/" + id; }
        public static string ToUserHref(this int? id) { return root + "users/" + id; }
        public static string ToVendorHref(this int? id) { return root + "vendors/" + id; }

		public static int? ToId(this string href) 
		{
			if (string.IsNullOrEmpty(href)) return null;
			return int.Parse(href.Substring(href.LastIndexOf('/') + 1)); 
		}

	}
}
