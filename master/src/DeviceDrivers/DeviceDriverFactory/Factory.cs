﻿/* This file is part of *DeviceDriverFactory*.
Copyright (C) 2015 Tiszai Istvan

*program name* is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.*/

namespace Brace.Shared.DeviceDrivers.DeviceDriverFactory
{
    using Enums;
    using Exceptions;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Brace.Shared.Diagnostics.Trace;

    public static class Factory
    {
        public static IList<object> CreateDriverInstance(DeviceType deviceType, string configuration, TraceWrapper traceWrapper)
        {
            switch (deviceType)
            {
                case DeviceType.LMS511Laser:
                    return Brace.Shared.DeviceDrivers.LMS511Laser.DriverFactory.CreateDriver(configuration, traceWrapper);
                case DeviceType.FTPServer:
                    break;
                default:
                    break;
            }

            throw new InvalidDeviceTypeException(String.Format("Device type {0} is invalid. There is no such registered device type.", deviceType), null);
        }
    }
}
