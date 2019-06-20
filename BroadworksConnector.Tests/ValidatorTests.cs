using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Validation;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BroadWorksConnector.Tests
{
    public class ValidatorTests
    {
        [Fact]
        public void TestRequirementMissing()
        {
            Assert.Throws<FieldNotSetException>(() =>
            {
                var request = new LoginRequest14sp4();
                Validator.Validate(request);
            });
        }

        [Fact]
        public void TestRequirementMet()
        {
            var request = new LoginRequest14sp4()
            {
                UserId = "test"
            };

            Assert.True(Validator.Validate(request));
        }

        [Fact]
        public void TestRequirementWithArrayNotMet()
        {
            Assert.Throws<FieldNotSetException>(() =>
            {
                var request = new GroupCommunicationBarringAuthorizationCodeAddListRequest()
                {
                    ServiceProviderId = "SID",
                    GroupId = "GID"
                };
                Validator.Validate(request);
            });
        }

        [Fact]
        public void TestRequirementWithArrayMet()
        {
            var request = new GroupCommunicationBarringAuthorizationCodeAddListRequest()
            {
                ServiceProviderId = "SID",
                GroupId = "GID",
                Code = new List<CommunicationBarringAuthorizationCodeEntry>()
                {
                    new CommunicationBarringAuthorizationCodeEntry()
                    {
                        Code = "123"
                    }
                }
            };
        }

        [Fact]
        public void TestChoiceNotMet()
        {
            Assert.Throws<ChoiceNotSetException>(() =>
            {
                var request = new UserModifyRequest16Endpoint();
                Validator.Validate(request);
            });
        }

        [Fact]
        public void TestMultipleChoiceSelections()
        {
            Assert.Throws<InvalidChoiceException>(() =>
            {
                var request = new SystemGetRegistrationContactListRequest()
                {
                    ResellerId = "reseller",
                    ServiceProviderId = "serviceProvider"
                };

                Validator.Validate(request);
            });
        }

        [Fact]
        public void TestSequenceSetInChoice()
        {
            var request = new SystemGetRegistrationContactListRequest()
            {
                GroupId = "group"
            };

            Assert.True(Validator.Validate(request));
        }

        [Fact]
        public void TestMultipleChoiceWithSequenceSequence()
        {
            Assert.Throws<InvalidChoiceException>(() =>
            {
                var request = new SystemGetRegistrationContactListRequest()
                {
                    GroupId = "group",
                    ResellerId = "reseller"
                };

                Validator.Validate(request);
            });
        }

        [Fact]
        public void TestChoiceWithOptionalMembers()
        {
            var request = new UserAddRequest21()
            {
                ServiceProviderId = "SP",
                GroupId = "GR",
                UserId = "user@test.com",
                FirstName = "John",
                LastName = "Doe",
                CallingLineIdFirstName = "John",
                CallingLineIdLastName = "Doe"
            };

            Assert.True(Validator.Validate(request));
        }

        [Fact]
        public void TestChoiceWithUnsetArrays()
        {
            Assert.Throws<ChoiceNotSetException>(() =>
            {
                var request = new GroupCallCenterAddAgentListRequest()
                {
                    ServiceUserId = "test@test.com"
                };

                Validator.Validate(request);
            });
        }

        [Fact]
        public void TestChoiceWithEmptyArrays()
        {
            var request = new GroupCallCenterAddAgentListRequest()
            {
                ServiceUserId = "test@test.com",
                AgentUserId = new List<string>() { "user@test.com" }
            };

            Assert.True(Validator.Validate(request));
        }

        [Fact]
        public void TestChoiceWithSetArrays()
        {
            Assert.Throws<InvalidChoiceException>(() =>
            {
                var request = new GroupCallCenterAddAgentListRequest()
                {
                    ServiceUserId = "test@test.com",
                    AgentUserId = new List<string>() { "user@test.com" },
                    AgentSkillList = new List<CallCenterSkillAgentList>()
                    {
                        new CallCenterSkillAgentList()
                        {
                            Agent = new List<string>() { "test" },
                            SkillLevel = 1
                        }
                    }
                };

                Validator.Validate(request);
            });
        }

        [Fact]
        public void TestOptionalGroup()
        {
            var request = new SystemGetRegistrationContactListRequest();
            Assert.True(Validator.Validate(request));
        }

        [Fact]
        public void TestIncompleteObjectInArray()
        {
            Assert.Throws<FieldNotSetException>(() =>
            {
                var request = new GroupAccessDeviceGetListRequest()
                {
                    ServiceProviderId = "SP",
                    GroupId = "G",
                    SearchCriteriaDeviceMACAddress = new List<SearchCriteriaDeviceMACAddress>() {
                        new SearchCriteriaDeviceMACAddress()
                        {
                            Value = "000000000000"
                        }
                    }
                };

                Validator.Validate(request);
            });
        }

        [Fact]
        public void TestCompletedObjectsInArray()
        {
            var request = new GroupAccessDeviceGetListRequest()
            {
                ServiceProviderId = "SP",
                GroupId = "G",
                SearchCriteriaDeviceMACAddress = new List<SearchCriteriaDeviceMACAddress>() {
                        new SearchCriteriaDeviceMACAddress()
                        {
                            Value = "000000000000",
                            IsCaseInsensitive = false,
                            Mode = SearchMode.EqualTo
                        },
                        new SearchCriteriaDeviceMACAddress()
                        {
                            Value = "999999999999",
                            IsCaseInsensitive = true,
                            Mode = SearchMode.EqualTo
                        }
                    }
            };
        }

        [Fact]
        public void TestLengthFailure()
        {
            Assert.Throws<LengthException>(() =>
            {
                var request = new FaxMessagingMenuKeysModifyEntry()
                {
                    SaveFaxMessageAndSkipToNext = "11"
                };

                Validator.Validate(request);
            });
        }
        
        [Fact]
        public void TestMinLengthFailure()
        {
            Assert.Throws<MinLengthException>(() =>
            {
                var request = new LoginRequest14sp4()
                {
                    UserId = ""
                };

                Validator.Validate(request);
            });
        }

        [Fact]
        public void TestMinLengthSuccess()
        { 
            var request = new LoginRequest14sp4()
            {
                UserId = "a"
            };

            Assert.True(Validator.Validate(request));
        }

        [Fact]
        public void TestMaxLengthFailure()
        {
            Assert.Throws<MaxLengthException>(() =>
            {
                var request = new LoginRequest14sp4()
                {
                    UserId = new String('a', 162)
                };

                Validator.Validate(request);
            });
        }

        [Fact]
        public void TestMaxLengthSuccess()
        {
            var request = new LoginRequest14sp4()
            {
                UserId = new String('a', 161)
            };

            Assert.True(Validator.Validate(request));
        }

        [Fact]
        public void TestPatternFailure()
        {
            Assert.Throws<PatternException>(() =>
            {
                var request = new FaxMessagingMenuKeysModifyEntry()
                {
                    SaveFaxMessageAndSkipToNext = "a"
                };

                Validator.Validate(request);
            });
        }

        [Fact]
        public void TestPatternSuccess()
        {
            var request = new FaxMessagingMenuKeysModifyEntry()
            {
                SaveFaxMessageAndSkipToNext = "#"
            };

            Assert.True(Validator.Validate(request));
        }

        [Fact]
        public void TestMinInclusiveFailure()
        {
            Assert.Throws<MinInclusiveException>(() =>
            {
                var request = new SystemExtensionLengthModifyRequest()
                {
                    MinExtensionLength = 1,
                    MaxExtensionLength = 1
                };

                Validator.Validate(request);
            });
        }

        [Fact]
        public void TestMinInclusiveSuccess()
        {
            var request = new SystemExtensionLengthModifyRequest()
            {
                MinExtensionLength = 3,
                MaxExtensionLength = 3
            };

            Assert.True(Validator.Validate(request));
        }

        [Fact]
        public void TestMaxInclusiveFailure()
        {
            Assert.Throws<MaxInclusiveException>(() =>
            {
                var request = new SystemExtensionLengthModifyRequest()
                {
                    MinExtensionLength = 21,
                    MaxExtensionLength = 21
                };

                Validator.Validate(request);
            });
        }

        [Fact]
        public void TestMaxInclusiveSuccess()
        {
            var request = new SystemExtensionLengthModifyRequest()
            {
                MinExtensionLength = 20,
                MaxExtensionLength = 20
            };

            Assert.True(Validator.Validate(request));
        }
    }
}
