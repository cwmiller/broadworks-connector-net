using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderAdminGetListRequest14.
    /// Contains a 7 column table with column headings "Administrator ID",
    /// "Last Name", "First Name", "Administrator Type", "Language", "Locale" and "Encoding".
    /// 
    /// The following columns are only returned in AS data mode:
    /// "Locale" and "Encoding"
    /// <see cref="ServiceProviderAdminGetListRequest14"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:1423""}]")]
    public class ServiceProviderAdminGetListResponse14 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _serviceProviderAdminTable;

        [XmlElement(ElementName = "serviceProviderAdminTable", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1423")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ServiceProviderAdminTable
        {
            get => _serviceProviderAdminTable;
            set
            {
                ServiceProviderAdminTableSpecified = true;
                _serviceProviderAdminTable = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminTableSpecified { get; set; }

    }
}
