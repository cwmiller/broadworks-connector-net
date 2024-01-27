using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderDeviceTypeCustomTagGetListRequest.
    /// Contains a table of custom configuration tags managed by the Device Management System on a per-device type basis for a service provider.
    /// In As data mode, the column headings are:
    /// "Tag Name", "Tag Value".
    /// In XS data mode, the column headings are:
    /// "Tag Name", "Tag Value" if request is invoked by an admin without system privileges.
    /// "Tag Name", "Tag Value", "Is Encrypted" if request is invoked by an admin with system privileges.
    /// <see cref="ServiceProviderDeviceTypeCustomTagGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:3258""}]")]
    public class ServiceProviderDeviceTypeCustomTagGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _serviceProviderDeviceTypeCustomTagsTable;

        [XmlElement(ElementName = "serviceProviderDeviceTypeCustomTagsTable", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3258")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ServiceProviderDeviceTypeCustomTagsTable
        {
            get => _serviceProviderDeviceTypeCustomTagsTable;
            set
            {
                ServiceProviderDeviceTypeCustomTagsTableSpecified = true;
                _serviceProviderDeviceTypeCustomTagsTable = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderDeviceTypeCustomTagsTableSpecified { get; set; }

    }
}
