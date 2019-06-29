using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemTimeZoneGetListRequest.
    /// Contains a 2 column table with column headings 'Key' and 'Display Name' and a row
    /// for each time zone.
    /// 
    /// Replaced by: SystemTimeZoneGetListResponse20 in AS data mode
    /// <see cref="SystemTimeZoneGetListRequest"/>
    /// <see cref="SystemTimeZoneGetListResponse20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:1982""}]")]
    public class SystemTimeZoneGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _timeZoneTable;

        [XmlElement(ElementName = "timeZoneTable", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:1982")]
        public BroadWorksConnector.Ocip.Models.C.OCITable TimeZoneTable
        {
            get => _timeZoneTable;
            set
            {
                TimeZoneTableSpecified = true;
                _timeZoneTable = value;
            }
        }

        [XmlIgnore]
        protected bool TimeZoneTableSpecified { get; set; }

    }
}
