using OutSystems.ExternalLibraries.SDK;
using Newtonsoft.Json;

namespace psn.PH.Structures
{
    [OSStructure(Description = "Auth info")]
    public struct AWS_Authenticationinfo
    {
        [OSStructureField(DataType = OSDataType.Text, Description = "AWS Region", IsMandatory = true)]
        public string Region;
        [OSStructureField(DataType = OSDataType.Text, Description = "AWS Access Key ID", IsMandatory = true)]
        public string AccessKeyId;
        [OSStructureField(DataType = OSDataType.Text, Description = "AWS Secret Access Key", IsMandatory = true)]
        public string SecretAccessKey;
    }

    [OSStructure(Description = "Message attribute")]
    public struct SQS_MessageAttribute
    {
        [OSStructureField(DataType = OSDataType.Text, Description = "Name of attribute", IsMandatory = true)]
        public string Name;
        [OSStructureField(DataType = OSDataType.Text, Description = "Amazon SQS supports the following logical data types: String, Number, and Binary. For the Number data type, you must use StringValue. See https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-message-metadata.html#sqs-message-attributes", IsMandatory = true)]
        public string DataType;
        [OSStructureField(DataType = OSDataType.Text, Description = "Value of attribute", IsMandatory = true)]
        public string Value;
    }

    [OSStructure(Description = "Message")]
    public struct SQS_Message
    {
        public string MessageId;
        public string MessageBody;
        public string ReceiptHandle;
        [OSStructureField(Description = "Message attributes", IsMandatory = false)]
        public List<SQS_MessageAttribute> MessageAttributes;
    }
}