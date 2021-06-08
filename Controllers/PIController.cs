using OSIsoft.AF.PI;
using OSIsoft.AF.Time;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Backend_PI.Controllers
{
    public class PIController : ApiController
    {
        private PIServer _piserver;
        private string _piserverIP = "202.44.12.146";
        private readonly NetworkCredential cred = new NetworkCredential("group3", "inc.382");
        // http://localhost:xxx/api/pi/value
        [HttpGet]
        [ActionName("DailyAverageDieselCycleTime")]
        public IHttpActionResult GetDailyAverageDieselCycleTime()
        {
            // connecto PI Server 
            var cn = piConnect();
            if(cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value81");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new {message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("DailyAverageGasohol95CycleTime")]
        public IHttpActionResult GetDailyAverageGasohol95CycleTime()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value82");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("DailyNumberOfTrucksWIPatSaleOffice")]
        public IHttpActionResult GetDailyNumberofTrucksWIPatSaleOffice()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0000-Value124");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("DailyNumberofTrucksWIPatInboundWeightBridge")]
        public IHttpActionResult GetDailyNumberofTrucksWIPatInboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0300-Value125");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("DailyNumberofTrucksWIPatDieselBay")]
        public IHttpActionResult GetDailyNumberofTrucksWIPatDieselBay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value126");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("DailyNumberofTrucksWIPatGasohol95Bay")]
        public IHttpActionResult GetDailyNumberofTrucksWIPatGasohol95Bay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value127");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("DailyNumberofTrucksWIPatOutboundWeightBridge")]
        public IHttpActionResult GetDailyNumberofTrucksWIPatOutboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0400-Value128");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("DailyAverageWaitingTimeAtSaleOffice")]
        public IHttpActionResult GetDailyAverageWaitingTimeAtSaleOffice()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0000-Value34");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("DailyAverageWaitingTimeAtInboundWeightBridge")]
        public IHttpActionResult GetDailyAverageWaitingTimeAtInboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0300-Value35");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("DailyAverageWaitingTimeAtDeiselBay")]
        public IHttpActionResult GetDailyAverageWaitingTimeAtDeiselBay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value36");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("DailyAverageWaitingTimeAtGasohol95Bay")]
        public IHttpActionResult GetDailyAverageWaitingTimeAtGasohol95Bay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value37");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("DailyAverageWaitingTimeAtOutboundWeightBridge")]
        public IHttpActionResult GetDailyAverageWaitingTimeAtOutboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0400-Value38");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("DailyNumberOfBusyTimeAtSaleOffice")]
        public IHttpActionResult GetDailyNumberOfBusyTimeAtSaleOffice()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0000-Value109");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("DailyNumberOfBusyTimeAtInboundWeightBridge")]
        public IHttpActionResult GetDailyNumberOfBusyTimeAtInboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0300-Value110");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("DailyNumberOfBusyTimeAtDieselBay")]
        public IHttpActionResult GetDailyNumberOfBusyTimeAtDieselBay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value111");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("DailyNumberOfBusyTimeAtGasohol95Bay")]
        public IHttpActionResult GetDailyNumberOfBusyTimeAtGasohol95Bay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value112");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("DailyNumberOfBusyTimeAtOutboundWeightBridge")]
        public IHttpActionResult GetDailyNumberOfBusyTimeAtOutboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0400-Value113");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("DailyTotalNumberOfFailedTimeAtSaleOffice")]
        public IHttpActionResult GetDailyTotalNumberOfFailedTimeAtSaleOffice()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0000-Value94");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("DailyTotalNumberOfFailedTimeAtInboundWeightBridge")]
        public IHttpActionResult GetDailyTotalNumberOfFailedTimeAtInboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0300-Value95");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("DailyTotalNumberOfFailedTimeAtDieselBay")]
        public IHttpActionResult GetDailyTotalNumberOfFailedTimeAtDieselBay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value96");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("DailyTotalNumberOfFailedTimeAtGasohol95Bay")]
        public IHttpActionResult GetDailyTotalNumberOfFailedTimeAtGasohol95Bay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value97");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("DailyTotalNumberOfFailedTimeAtOutboundWeightBridge")]
        public IHttpActionResult GetDailyTotalNumberOfFailedTimeAtOutboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0400-Value98");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("DailyAverageNumberOfQueueAtSaleOffice")]
        public IHttpActionResult GetDailyAverageNumberOfQueueAtSaleOffice()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0000-Value19");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("DailyAverageNumberOfQueueAtInboundWeightBridge")]
        public IHttpActionResult GetDailyAverageNumberOfQueueAtInboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0300-Value20");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("DailyAverageNumberOfQueueAtDieselBay")]
        public IHttpActionResult GetDailyAverageNumberOfQueueAtDieselBay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value21");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("DailyAverageNumberOfQueueAtGasohol95Bay")]
        public IHttpActionResult GetDailyAverageNumberOfQueueAtGasohol95Bay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value22");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("DailyAverageNumberOfQueueAtOutboundWeightBridge")]
        public IHttpActionResult GetDailyAverageNumberOfQueueAtOutboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0400-Value23");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyAverageDieselCycleTime")]
        public IHttpActionResult GetWeeklyAverageDieselCycleTime()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value86");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyAverageGasohol95CycleTime")]
        public IHttpActionResult GetWeeklyAverageGasohol95CycleTime()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value87");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyNumberOfTrucksWIPatSaleOffice")]
        public IHttpActionResult GetWeeklyNumberOfTrucksWIPatSaleOffice()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0000-Value129");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyNumberOfTrucksWIPatInboundWeightBridge")]
        public IHttpActionResult GetWeeklyNumberOfTrucksWIPatInboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0300-Value130");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyNumberOfTrucksWIPatDieselBay")]
        public IHttpActionResult GetWeeklyNumberOfTrucksWIPatDieselBay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value131");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyNumberOfTrucksWIPatGasohol95Bay")]
        public IHttpActionResult GetWeeklyNumberOfTrucksWIPatGasohol95Bay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value132");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyNumberOfTrucksWIPatOutboundWeightBridge")]
        public IHttpActionResult GetWeeklyNumberOfTrucksWIPatOutboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0400-Value133");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyScheduledUtilizationOfSaleOffice")]
        public IHttpActionResult GetWeeklyScheduledUtilizationOfSaleOffice()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0000-Value69");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyScheduledUtilizationOfInboundWeightBridge")]
        public IHttpActionResult GetWeeklyScheduledUtilizationOfInboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0300-Value70");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyScheduledUtilizationOfDieselBay")]
        public IHttpActionResult GetWeeklyScheduledUtilizationOfDieselBay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value71");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyScheduledUtilizationOfGasohol95Bay")]
        public IHttpActionResult GetWeeklyScheduledUtilizationOfGasohol95Bay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value72");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyScheduledUtilizationOfOutboundWeightBridge")]
        public IHttpActionResult GetWeeklyScheduledUtilizationOfOutboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0400-Value73");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyAverageWaitingTimeAtSaleOffice")]
        public IHttpActionResult GetWeeklyAverageWaitingTimeAtSaleOffice()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0000-Value39");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyAverageWaitingTimeAtInboundWeightBridge")]
        public IHttpActionResult GetWeeklyAverageWaitingTimeAtInboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0300-Value40");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyAverageWaitingTimeAtDeiselBay")]
        public IHttpActionResult GetWeeklyAverageWaitingTimeAtDeiselBay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value41");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyAverageWaitingTimeAtGasohol95Bay")]
        public IHttpActionResult GetWeeklyAverageWaitingTimeAtGasohol95Bay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value42");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyAverageWaitingTimeAtOutboundWeightBridge")]
        public IHttpActionResult GetWeeklyAverageWaitingTimeAtOutboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0400-Value43");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyNumberOfBusyTimeAtSaleOffice")]
        public IHttpActionResult GetWeeklyNumberOfBusyTimeAtSaleOffice()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0000-Value114");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyNumberOfBusyTimeAtInboundWeightBridge")]
        public IHttpActionResult GetWeeklyNumberOfBusyTimeAtInboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0300-Value115");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyNumberOfBusyTimeAtDieselBay")]
        public IHttpActionResult GetWeeklyNumberOfBusyTimeAtDieselBay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value116");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyNumberOfBusyTimeAtGasohol95Bay")]
        public IHttpActionResult GetWeeklyNumberOfBusyTimeAtGasohol95Bay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value117");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyNumberOfBusyTimeAtOutboundWeightBridge")]
        public IHttpActionResult GetWeeklyNumberOfBusyTimeAtOutboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0400-Value118");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyTotalNumberOfFailedTimeAtSaleOffice")]
        public IHttpActionResult GetWeeklyTotalNumberOfFailedTimeAtSaleOffice()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0000-Value99");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyTotalNumberOfFailedTimeAtInboundWeightBridge")]
        public IHttpActionResult GetWeeklyTotalNumberOfFailedTimeAtInboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0300-Value100");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyTotalNumberOfFailedTimeAtDieselBay")]
        public IHttpActionResult GetWeeklyTotalNumberOfFailedTimeAtDieselBay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value101");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyTotalNumberOfFailedTimeAtGasohol95Bay")]
        public IHttpActionResult GetWeeklyTotalNumberOfFailedTimeAtGasohol95Bay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value102");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyTotalNumberOfFailedTimeAtOutboundWeightBridge")]
        public IHttpActionResult GetWeeklyTotalNumberOfFailedTimeAtOutboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0400-Value103");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyAverageNumberOfQueueAtSaleOffice")]
        public IHttpActionResult GetWeeklyAverageNumberOfQueueAtSaleOffice()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0000-Value24");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyAverageNumberOfQueueAtInboundWeightBridge")]
        public IHttpActionResult GetWeeklyAverageNumberOfQueueAtInboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0300-Value25");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyAverageNumberOfQueueAtDieselBay")]
        public IHttpActionResult GetWeeklyAverageNumberOfQueueAtDieselBay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value26");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyAverageNumberOfQueueAtGasohol95Bay")]
        public IHttpActionResult GetWeeklyAverageNumberOfQueueAtGasohol95Bay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value27");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyAverageNumberOfQueueAtOutboundWeightBridge")]
        public IHttpActionResult GetWeeklyAverageNumberOfQueueAtOutboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value28");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyAverageDieselCycleTime")]
        public IHttpActionResult GetMonthlyAverageDieselCycleTime()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value91");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyAverageGasohol95CycleTime")]
        public IHttpActionResult GetMonthlyAverageGasohol95CycleTime()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value92");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyNumberOfTrucksWIPatSaleOffice")]
        public IHttpActionResult GetMonthlyNumberOfTrucksWIPatSaleOffice()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0000-Value134");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyNumberOfTrucksWIPatInboundWeightBridge")]
        public IHttpActionResult GetMonthlyNumberOfTrucksWIPatInboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0300-Value135");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyNumberOfTrucksWIPatDieselBay")]
        public IHttpActionResult GetMonthlyNumberOfTrucksWIPatDieselBay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value136");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyNumberOfTrucksWIPatGasohol95Bay")]
        public IHttpActionResult GetMonthlyNumberOfTrucksWIPatGasohol95Bay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value137");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyNumberOfTrucksWIPatOutboundWeightBridge")]
        public IHttpActionResult GetMonthlyNumberOfTrucksWIPatOutboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0400-Value138");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyScheduledUtilizationOfSaleOffice")]
        public IHttpActionResult GetMonthlyScheduledUtilizationOfSaleOffice()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0000-Value74");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyScheduledUtilizationOfInboundWeightBridge")]
        public IHttpActionResult GetMonthlyScheduledUtilizationOfInboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0300-Value75");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyScheduledUtilizationOfDieselBay")]
        public IHttpActionResult GetMonthlyScheduledUtilizationOfDieselBay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value76");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyScheduledUtilizationOfGasohol95Bay")]
        public IHttpActionResult GetMonthlyScheduledUtilizationOfGasohol95Bay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value77");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyScheduledUtilizationOfOutboundWeightBridge")]
        public IHttpActionResult GetMonthlyScheduledUtilizationOfOutboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0400-Value78");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyAverageWaitingTimeAtSaleOffice")]
        public IHttpActionResult GetMonthlyAverageWaitingTimeAtSaleOffice()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0000-Value44");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyAverageWaitingTimeAtInboundWeightBridge")]
        public IHttpActionResult GetMonthlyAverageWaitingTimeAtInboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0300-Value45");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyAverageWaitingTimeAtDeiselBay")]
        public IHttpActionResult GetMonthlyAverageWaitingTimeAtDeiselBay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value46");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyAverageWaitingTimeAtGasohol95Bay")]
        public IHttpActionResult GetMonthlyAverageWaitingTimeAtGasohol95Bay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value47");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyAverageWaitingTimeAtOutboundWeightBridge")]
        public IHttpActionResult GetMonthlyAverageWaitingTimeAtOutboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0400-Value48");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyNumberOfBusyTimeAtSaleOffice")]
        public IHttpActionResult GetMonthlyNumberOfBusyTimeAtSaleOffice()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0000-Value119");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyNumberOfBusyTimeAtInboundWeightBridge")]
        public IHttpActionResult GetMonthlyNumberOfBusyTimeAtInboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0300-Value120");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyNumberOfBusyTimeAtDieselBay")]
        public IHttpActionResult GetMonthlyNumberOfBusyTimeAtDieselBay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value121");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyNumberOfBusyTimeAtGasohol95Bay")]
        public IHttpActionResult GetMonthlyNumberOfBusyTimeAtGasohol95Bay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value122");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyNumberOfBusyTimeAtOutboundWeightBridge")]
        public IHttpActionResult GetMonthlyNumberOfBusyTimeAtOutboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0400-Value123");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyTotalNumberOfFailedTimeAtSaleOffice")]
        public IHttpActionResult GetMonthlyTotalNumberOfFailedTimeAtSaleOffice()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0000-Value104");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyTotalNumberOfFailedTimeAtInboundWeightBridge")]
        public IHttpActionResult GetMonthlyTotalNumberOfFailedTimeAtInboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0300-Value105");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyTotalNumberOfFailedTimeAtDieselBay")]
        public IHttpActionResult GetMonthlyTotalNumberOfFailedTimeAtDieselBay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value106");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyTotalNumberOfFailedTimeAtGasohol95Bay")]
        public IHttpActionResult GetMonthlyTotalNumberOfFailedTimeAtGasohol95Bay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value107");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyTotalNumberOfFailedTimeAtOutboundWeightBridge")]
        public IHttpActionResult GetMonthlyTotalNumberOfFailedTimeAtOutboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0400-Value108");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyAverageNumberOfQueueAtSaleOffice")]
        public IHttpActionResult GetMonthlyAverageNumberOfQueueAtSaleOffice()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value29");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyAverageNumberOfQueueAtInboundWeightBridge")]
        public IHttpActionResult GetMonthlyAverageNumberOfQueueAtInboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value30");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyAverageNumberOfQueueAtDieselBay")]
        public IHttpActionResult GetMonthlyAverageNumberOfQueueAtDieselBay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value31");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyAverageNumberOfQueueAtGasohol95Bay")]
        public IHttpActionResult GetMonthlyAverageNumberOfQueueAtGasohol95Bay()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value32");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("MonthlyAverageNumberOfQueueAtOutboundWeightBridge")]
        public IHttpActionResult GetMonthlyAverageNumberOfQueueAtOutboundWeightBridge()
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A003-S3-0100-Value33");
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("value")]
        public IHttpActionResult GetValueFromPITagByTagname(string id)
        {
            // connecto PI Server 
            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, id);
                var timeRange = new AFTimeRange("*-4y", "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        private PIServer piConnect()
        {
            // connecto PI Server 
            _piserver = new PIServers()[_piserverIP];
            _piserver.Connect(cred);

            return _piserver;
        }

    }
}
