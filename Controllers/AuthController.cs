using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplicationBackEnd.Controllers
{
    public class AuthController : ApiController
    {
        [HttpGet]
        [ActionName("baystation")]
        public IHttpActionResult GetBays()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.C_Bay_Station__.OrderBy(o => o.PO_Number).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }

        [ActionName("saleoffice")]
        public IHttpActionResult GetSaleOffices()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.C_Sale_Office__.OrderBy(o => o.PO_Number).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }

        [ActionName("customer")]
        public IHttpActionResult GetCustomers()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.Customer_.OrderBy(o => o.CustomerAddress).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }

        [ActionName("truck")]
        public IHttpActionResult GetTrucks()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.Truck_.OrderBy(o => o.Vehicle_Number).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }

        [ActionName("employee")]
        public IHttpActionResult GetEmployees()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.Employee_.OrderBy(o => o.Employee_ID).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }

        [ActionName("payment")]
        public IHttpActionResult GetPayments()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.Payment_.OrderBy(o => o.Payment_No_).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }

        [ActionName("transaction")]
        public IHttpActionResult GetTransactions()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.Transaction_.OrderBy(o => o.Transaction_ID).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }

        [ActionName("transaction2")]
        public IHttpActionResult GetTransactions2()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.Transaction2_.OrderBy(o => o.Week).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }

        [ActionName("journal")]
        public IHttpActionResult GetJournalizingTransaction()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.C_Journalize___.OrderBy(o => o.PK_journalize).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }

        [ActionName("inventory")]
        public IHttpActionResult GetInventoryStockCard()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.C_Inventory_Stock_Card__.OrderBy(o => o.Patrol_Type).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }

        [ActionName("monthlyincomestatement")]
        public IHttpActionResult GetMonthlyIncomeStatement()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.C_Monthly_Income_Statement__.OrderBy(o => o.Type).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }

        [ActionName("reconciliation")]
        public IHttpActionResult GetReconciliation()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.Reconciliation_.OrderBy(o => o.Payment_No_).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }

        [ActionName("purchase")]
        public IHttpActionResult GetPurchase()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.Purchase_.OrderBy(o => o.PO_Number).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }

        [ActionName("generalledgeraccountpayable")]
        public IHttpActionResult GetGeneralLedgerAccountPayable()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.GLAccountPayable_.OrderBy(o => o.PK_payable).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }

        [ActionName("generalledgeraccountrecievable")]
        public IHttpActionResult GetGeneralLedgerAccountRecievable()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.GLAccountRecievable_.OrderBy(o => o.PK_recievable).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }

        [ActionName("generalledgercash")]
        public IHttpActionResult GetGeneralLedgerCash()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.GLCash_.OrderBy(o => o.PK_cash).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }

        [ActionName("generalledgerdiesel")]
        public IHttpActionResult GetGeneralLedgerDiesel()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.GLDiesel_.OrderBy(o => o.PK_diesel).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }

        [ActionName("generalledgergasohol95")]
        public IHttpActionResult GetGeneralLedgerGasohol95()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.GLGasohol95_.OrderBy(o => o.PK_gasohol95).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }

        [ActionName("invoice")]
        public IHttpActionResult GetInvoice()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.Invoice_.OrderBy(o => o.Invoice_No_).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }

        [ActionName("totalcalculate")]
        public IHttpActionResult GetTotalCalculate()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.C_Total_Calculate___.OrderBy(o => o.Total_SALE).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }

        [ActionName("starttimeendtimedieselbay")]
        public IHttpActionResult GetStartTimeEndTimeDeselBay()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.C_SE_Diesel_Bay__.OrderBy(o => o.PK_SEDB).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }

        [ActionName("starttimeendtimegasohol95bay")]
        public IHttpActionResult GetStartTimeEndTimeGasohol95Bay()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.SE_Gasohol95_.OrderBy(o => o.PK_SEGB).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }

        [ActionName("starttimeendtimeinboundweightbridge")]
        public IHttpActionResult GetStartTimeEndTimeInboundWeightBridge()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.SE_InboundWB_.OrderBy(o => o.PK_SEIWB).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }

        [ActionName("starttimeendtimeoutboundweightbridge")]
        public IHttpActionResult GetStartTimeEndTimeOutboundWeightBridge()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.SE_OutboundWB_.OrderBy(o => o.PK_SEOWB).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }

        [ActionName("starttimeendtimesaleoffice")]
        public IHttpActionResult GetStartTimeEndTimeSaleOffice()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.SE_SaleOffice_.OrderBy(o => o.PK_SESO).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }

        [ActionName("busydieselbay")]
        public IHttpActionResult GetBusyDiesel()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.BusyDiesel_.OrderBy(o => o.PK_busyDB).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }

        [ActionName("busyexitgate")]
        public IHttpActionResult GetBusyExitGate()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.BusyExitGate_.OrderBy(o => o.PK_busyEG).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }

        [ActionName("busygasohol95bay")]
        public IHttpActionResult GetbusyGasohol95Bay()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.BusyGasohol95_.OrderBy(o => o.PK_busyGB).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }

        [ActionName("busyinboundweightbridge")]
        public IHttpActionResult GetBusyInboundWeightBridge()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.BusyInboundWB_.OrderBy(o => o.PK_busyIWB).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }

        [ActionName("busyoutboundweightbridge")]
        public IHttpActionResult GetBusyOutboundWeightBridge()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.BusyOutboundWB_.OrderBy(o => o.PK_busyOWB).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }

        [ActionName("busysaleoffice")]
        public IHttpActionResult GetBusySaleOffice()
        {
            using (Capstone2Entities9 _databaseContext = new Capstone2Entities9())
            {
                //var users = _databaseContext.User_.ToList();
                var Users = _databaseContext.BusySalesOffice_.OrderBy(o => o.PK_busySO).ToList();

                return Ok(new { result = Users, message = "success" });
            }
        }
    }
}