	
using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections.Generic;

namespace BikeShop.Domain
{
    // ############################################################################
    // #
    // #        ---==>  T H I S  F I L E  W A S  G E N E R A T E D  <==---
    // #
    // # This file was generated by the CodeGen Prototype
    // # Generated on 11/22/2014 12:32:31 AM
    // #
    // # Edits to this file may cause incorrect behavior and will be lost
    // # if the code is regenerated.
    // #
    // ############################################################################
	
	// BikeShop Context. hosts all repositories

	public static class BikeShopContext
	{
		static Db db = new BikeShopDb();
		
		// entity specific repositories

        public static Carts Carts { get { return new Carts(); } }
        public static CartItems CartItems { get { return new CartItems(); } }
        public static Categories Categories { get { return new Categories(); } }
        public static Errors Errors { get { return new Errors(); } }
        public static Orders Orders { get { return new Orders(); } }
        public static OrderDetails OrderDetails { get { return new OrderDetails(); } }
        public static OrderNumbers OrderNumbers { get { return new OrderNumbers(); } }
        public static Products Products { get { return new Products(); } }
        public static Ratings Ratings { get { return new Ratings(); } }
        public static Users Users { get { return new Users(); } }
        public static Vendors Vendors { get { return new Vendors(); } }

		// general purpose operations

		public static void Execute(string sql, params object[] parms) { db.Execute( sql, parms ); }
		public static IEnumerable<dynamic> Query(string sql, params object[] parms) { return db.Query( sql, parms ); }
		public static object Scalar(string sql, params object[] parms) { return db.Scalar( sql, parms ); }

		public static DataSet GetDataSet(string sql, params object[] parms) { return db.GetDataSet( sql, parms ); }
		public static DataTable GetDataTable(string sql, params object[] parms) { return db.GetDataTable( sql, parms ); }
		public static DataRow GetDataRow(string sql, params object[] parms) { return db.GetDataRow( sql, parms ); }
	}
}