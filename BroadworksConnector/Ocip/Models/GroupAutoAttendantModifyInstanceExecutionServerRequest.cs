using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAutoAttendantModifyInstanceExecutionServerRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceUserId;

    [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
    public string ServiceUserId {
        get => _serviceUserId;
        set {
            ServiceUserIdSpecified = true;
            _serviceUserId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceUserIdSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.AutoAttendantModifyMenuExecutionServer _businessHoursMenu;

    [XmlElement(ElementName = "businessHoursMenu", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AutoAttendantModifyMenuExecutionServer BusinessHoursMenu {
        get => _businessHoursMenu;
        set {
            BusinessHoursMenuSpecified = true;
            _businessHoursMenu = value;
        }
    }

    [XmlIgnore]
    public bool BusinessHoursMenuSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.AutoAttendantModifyMenuExecutionServer _afterHoursMenu;

    [XmlElement(ElementName = "afterHoursMenu", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AutoAttendantModifyMenuExecutionServer AfterHoursMenu {
        get => _afterHoursMenu;
        set {
            AfterHoursMenuSpecified = true;
            _afterHoursMenu = value;
        }
    }

    [XmlIgnore]
    public bool AfterHoursMenuSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.AutoAttendantModifyMenuExecutionServer _holidayMenu;

    [XmlElement(ElementName = "holidayMenu", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AutoAttendantModifyMenuExecutionServer HolidayMenu {
        get => _holidayMenu;
        set {
            HolidayMenuSpecified = true;
            _holidayMenu = value;
        }
    }

    [XmlIgnore]
    public bool HolidayMenuSpecified { get; set; }
}
}
