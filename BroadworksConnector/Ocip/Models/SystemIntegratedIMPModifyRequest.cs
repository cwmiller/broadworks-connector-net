using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system Integrated IMP service attributes.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// The following elements are only used in AS data mode:
    /// boshURL
    /// allowImpPasswordRetrieval
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""23389100b68cef3aa07ee12ac7a2bd16:297""}]")]
    public class SystemIntegratedIMPModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _serviceDomain;

        [XmlElement(ElementName = "serviceDomain", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:297")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ServiceDomain
        {
            get => _serviceDomain;
            set
            {
                ServiceDomainSpecified = true;
                _serviceDomain = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceDomainSpecified { get; set; }

        private int? _servicePort;

        [XmlElement(ElementName = "servicePort", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:297")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int? ServicePort
        {
            get => _servicePort;
            set
            {
                ServicePortSpecified = true;
                _servicePort = value;
            }
        }

        [XmlIgnore]
        protected bool ServicePortSpecified { get; set; }

        private bool _addServiceProviderInIMPUserId;

        [XmlElement(ElementName = "addServiceProviderInIMPUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:297")]
        public bool AddServiceProviderInIMPUserId
        {
            get => _addServiceProviderInIMPUserId;
            set
            {
                AddServiceProviderInIMPUserIdSpecified = true;
                _addServiceProviderInIMPUserId = value;
            }
        }

        [XmlIgnore]
        protected bool AddServiceProviderInIMPUserIdSpecified { get; set; }

        private string _boshURL;

        [XmlElement(ElementName = "boshURL", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:297")]
        [MinLength(1)]
        [MaxLength(256)]
        public string BoshURL
        {
            get => _boshURL;
            set
            {
                BoshURLSpecified = true;
                _boshURL = value;
            }
        }

        [XmlIgnore]
        protected bool BoshURLSpecified { get; set; }

        private bool _allowImpPasswordRetrieval;

        [XmlElement(ElementName = "allowImpPasswordRetrieval", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:297")]
        public bool AllowImpPasswordRetrieval
        {
            get => _allowImpPasswordRetrieval;
            set
            {
                AllowImpPasswordRetrievalSpecified = true;
                _allowImpPasswordRetrieval = value;
            }
        }

        [XmlIgnore]
        protected bool AllowImpPasswordRetrievalSpecified { get; set; }

    }
}
