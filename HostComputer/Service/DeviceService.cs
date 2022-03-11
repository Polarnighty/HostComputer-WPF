using HostComputer.DataBase;
using HostComputer.Entity;
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

                    // 获取协议信息
                    if (deviceModel.CommType == 1)
                    {
                        var Modbus = context.protocolModbus.SingleOrDefault();
                        if (Modbus!=null)
                        {
                            deviceModel.Modbus.IP = Modbus.IP;
                            deviceModel.Modbus.Port = Modbus.Port;
                            deviceModel.Modbus.BaudRate = Modbus.BaudRate;
                        }

                    }
                    else if (deviceModel.CommType == 1)
                    {
                        var S7 = context.protocolS7.SingleOrDefault();
                        if (S7 != null)
                        {
                            deviceModel.S7.IP = S7.IP;
                            deviceModel.S7.Port = S7.Port;
                            deviceModel.S7.Rock = S7.Rock;
                            deviceModel.S7.Slot = S7.Slot;
                        }
                    }
                }
            }
            return null;
        }

    }
}
