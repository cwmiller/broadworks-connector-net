using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSystemServiceDnGetUsageListRequest.
    /// The table columns are:  "Phone Number", "Id",
    /// "Name", and "System Service".
    /// The possible values for "System Service" is "System Voice Portal".
    /// <see cref="SystemSystemServiceDnGetUsageListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:18545""}]")]
    public class SystemSystemServiceDnGetUsageListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _dnUtilizationTable;

        [XmlElement(ElementName = "dnUtilizationTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18545")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DnUtilizationTable
        {
            get => _dnUtilizationTable;
            set
            {
                DnUtilizationTableSpecified = true;
                _dnUtilizationTable = value;
            }
        }

        [XmlIgnore]
        protected bool DnUtilizationTableSpecified { get; set; }

    }
}
