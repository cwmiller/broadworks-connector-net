using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the Alternate Carrier Selection parameters.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:4727""}]")]
    public class ServiceProviderHPBXAlternateCarrierSelectionModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:4727")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        protected bool _processCbcCarrierSelection;

        [XmlElement(ElementName = "processCbcCarrierSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:4727")]
        public bool ProcessCbcCarrierSelection
        {
            get => _processCbcCarrierSelection;
            set
            {
                ProcessCbcCarrierSelectionSpecified = true;
                _processCbcCarrierSelection = value;
            }
        }

        [XmlIgnore]
        protected bool ProcessCbcCarrierSelectionSpecified { get; set; }

        protected string _preselectedLocalCarrier;

        [XmlElement(ElementName = "preselectedLocalCarrier", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:4727")]
        [MinLength(1)]
        [MaxLength(80)]
        public string PreselectedLocalCarrier
        {
            get => _preselectedLocalCarrier;
            set
            {
                PreselectedLocalCarrierSpecified = true;
                _preselectedLocalCarrier = value;
            }
        }

        [XmlIgnore]
        protected bool PreselectedLocalCarrierSpecified { get; set; }

        protected string _preselectedDistantCarrier;

        [XmlElement(ElementName = "preselectedDistantCarrier", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:4727")]
        [MinLength(1)]
        [MaxLength(80)]
        public string PreselectedDistantCarrier
        {
            get => _preselectedDistantCarrier;
            set
            {
                PreselectedDistantCarrierSpecified = true;
                _preselectedDistantCarrier = value;
            }
        }

        [XmlIgnore]
        protected bool PreselectedDistantCarrierSpecified { get; set; }

    }
}
