// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// 消息条目.
/// </summary>
public class MessageItem
{
    /// <summary>
    /// 条目ID.
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; set; }
}

/// <summary>
/// 消息条目详情.
/// </summary>
public class MessageItemDetail
{
    /// <summary>
    /// 消息类型.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    /// 消息对象.
    /// </summary>
    [JsonPropertyName("business")]
    public string Business { get; set; }

    /// <summary>
    /// 消息对象Id.
    /// </summary>
    [JsonPropertyName("business_id")]
    public string BusinessId { get; set; }

    /// <summary>
    /// 标题.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// 对象中包含的图片.
    /// </summary>
    [JsonPropertyName("image")]
    public string Image { get; set; }

    /// <summary>
    /// 原始网址.
    /// </summary>
    [JsonPropertyName("uri")]
    public string Uri { get; set; }
}

/// <summary>
/// 消息指针.
/// </summary>
public class MessageCursor
{
    /// <summary>
    /// 是否已到末尾.
    /// </summary>
    [JsonPropertyName("is_end")]
    public bool IsEnd { get; set; }

    /// <summary>
    /// 标识符.
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; set; }

    /// <summary>
    /// 发生时间.
    /// </summary>
    [JsonPropertyName("time")]
    public long Time { get; set; }
}

