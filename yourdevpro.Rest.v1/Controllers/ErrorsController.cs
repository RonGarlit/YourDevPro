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
	
	// Change code for each method

	public class ErrorsController : BaseApiController
	{

		// GET Collection

		[HttpGet]
		public IEnumerable<ApiError> Get(string expand = "")
		{
			return new List<ApiError>();
		}

		// GET Single

		[HttpGet]
		public ApiError Get(int? id, string expand = "")
		{
			return new ApiError();
		}

		// POST = Insert

		[HttpPost]
		public ApiError Post([FromBody] ApiError apierror)
		{
			return apierror;
		}

		// PUT = Update

		[HttpPut]
		public ApiError Put(int? id, [FromBody] ApiError apierror)
		{
			return apierror;
		}

		// DELETE

		[HttpDelete]
		public ApiError Delete(int? id)
		{
			return new ApiError();
		}
	}
}
