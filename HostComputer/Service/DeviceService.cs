using HostComputer.DataBase;
using HostComputer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostComputer.Service
{
    public class DeviceService : BaseService
    {
        //public DeviceService(SqlContext context) : base(context)
        //{

        //}

        public List<DeviceModel> GetDevices()
        {
            List<DeviceModel> deviceModels = new List<DeviceModel>();
            // 获取点位信息
            // 获取设备信息
            var d_info = context.devices.AsEnumerable();
            if (d_info != null && d_info.Count() > 0)
            {
                var deviceModel = new DeviceModel();
                foreach (var item in d_info)
                {
                    deviceModel.Name = item.Name;
                    deviceModel.SN = item.SN;
                    deviceModel.CommType = item.CommType;
                }
                // 获取协议信息
                if (deviceModel.CommType==1)
                {

                }
            }
            return null;
        }

        public void GetProtocolSettings(int d_id, int type = 1)
        {
            if (type == 2)
            {
                return;
            }
        }
    }
}
