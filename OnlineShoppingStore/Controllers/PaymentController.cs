using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using OnlineShoppingStore.DAL;
using OnlineShoppingStore.Models;
using OnlineShoppingStore.Models.Home;
using OnlineShoppingStore.Repository;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using PayPal.Api;

namespace OnlineShoppingStore.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Payment
        public ActionResult PaymentWithPapal2()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PaymentWithPapal2(Shippingdetail shippingdetail)
        {
            dbMyOnlineShoppingEntities db = new dbMyOnlineShoppingEntities();

            Tbl_ShippingDetails tbl = new Tbl_ShippingDetails();
            tbl.Adress = shippingdetail.Adress;
            tbl.MemberId = shippingdetail.MemberId;
            tbl.City = shippingdetail.City;
            tbl.State = shippingdetail.State;
            tbl.Country = shippingdetail.Country;
            tbl.ZipCode = shippingdetail.ZipCode;
            tbl.AmountPaid = shippingdetail.AmountPaid;
            tbl.PaymentType = shippingdetail.PaymentType;

            db.Tbl_ShippingDetails.Add(tbl);
            db.SaveChanges();

            /* Item cart = (Item)Session["cart"];
             var shippingdetail = new Shippingdetail()
             {
                 ShippingDetailId = 79,
                 MemberId = 89,
                 Adress = frc["Adress"],
                 City = frc["City"],
                 State = frc["State"],
                 Country = frc["Country"],
                 ZipCode = frc["ZipCode"],
                 OrderId = 10000,
                 AmountPaid = 10000,
                 PaymentType = "Cash",
             };
             ctx.Tbl_ShippingDetails.Add(shippingdetail);
             ctx.SaveChanges();*/


            /*var Adress = Request.Form["Adress"];
            var City = Request.Form["City"];
            var State = Request.Form["State"];
            var Country = Request.Form["Country"];
            var Zipcode = Request.Form["Zipcode"];


            var db = ctx.Open("dbMyOnlineShoppingEntities");
            var insertCommand = "INSERT INTO Tbl_ShippingDetails (Adress, City, State, Country, Zipcode) Values(@0, @1, @2, @3, @4)";
            db.Execute(insertCommand, Adress, City, State, Country, Zipcode);
            Response.Redirect("~/SuccessView");*/


            /*SqlConnection conn = new SqlConnection("Data Source=DESKTOP-M407LSF;Initial Catalog=dbMyOnlineShopping;Integrated Security=True");

                conn.Open();

                SqlCommand cmd = new SqlCommand("spAddOrder", conn);
                cmd.CommandType = CommandType.StoredProcedure;*/



            /*cmd.Parameters.AddWithValue("@Adress", shippingdetail.Adress);
            cmd.Parameters.AddWithValue("@MemberId", shippingdetail.MemberId);


                        SqlParameter paramAdress = new SqlParameter();
                        paramAdress.ParameterName = "@Adress";
                        paramAdress.Value = shippingdetail.Adress;
                        cmd.Parameters.Add(paramAdress
            cmd.ExecuteNonQuery();
            conn.Close();*/

            return RedirectToAction("Index","Home");
        }
    }
}

