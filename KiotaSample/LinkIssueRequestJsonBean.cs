using AtlassianClient.Models;
using Microsoft.Kiota.Abstractions.Serialization;

public class LinkIssueRequestJsonBean : IParsable {

    public Comment? Comment { get; set; }
    public LinkedIssue? InwardIssue { get; set; }
    public LinkedIssue? OutwardIssue { get; set; }
    public IssueLinkType? Type { get; set; }

    public static LinkIssueRequestJsonBean CreateFromDiscriminatorValue(IParseNode parseNode) {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new LinkIssueRequestJsonBean();
    }

    public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
        return new Dictionary<string, Action<IParseNode>> {
                {"comment", n => { Comment = n.GetObjectValue(Comment.CreateFromDiscriminatorValue); } },
                {"inwardIssue", n => { InwardIssue = n.GetObjectValue(LinkedIssue.CreateFromDiscriminatorValue); } },
                {"outwardIssue", n => { OutwardIssue = n.GetObjectValue(LinkedIssue.CreateFromDiscriminatorValue); } },
                {"type", n => { Type = n.GetObjectValue(IssueLinkType.CreateFromDiscriminatorValue); } },
            };
    }

    public void Serialize(ISerializationWriter writer) {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteObjectValue("comment", Comment);
        writer.WriteObjectValue("inwardIssue", InwardIssue);
        writer.WriteObjectValue("outwardIssue", OutwardIssue);
        writer.WriteObjectValue("type", Type);
    }
}

