// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Numerics;


public class movie
{
    public List<Movy> Movy { get; set; }
}

public class Torrent
{
    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("hash")]
    public string Hash { get; set; }

    [JsonProperty("quality")]
    public string Quality { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("seeds")]
    public int Seeds { get; set; }

    [JsonProperty("peers")]
    public int Peers { get; set; }

    [JsonProperty("size")]
    public string Size { get; set; }

    [JsonProperty("size_bytes")]
    public long SizeBytes { get; set; }

    [JsonProperty("date_uploaded")]
    public string DateUploaded { get; set; }

    [JsonProperty("date_uploaded_unix")]
    public int DateUploadedUnix { get; set; }
}

public class Movy
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("imdb_code")]
    public string ImdbCode { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("title_english")]
    public string TitleEnglish { get; set; }

    [JsonProperty("title_long")]
    public string TitleLong { get; set; }

    [JsonProperty("slug")]
    public string Slug { get; set; }

    [JsonProperty("year")]
    public int Year { get; set; }

    [JsonProperty("rating")]
    public double Rating { get; set; }

    [JsonProperty("runtime")]
    public int Runtime { get; set; }

    [JsonProperty("genres")]
    public List<string> Genres { get; set; }

    [JsonProperty("summary")]
    public string Summary { get; set; }

    [JsonProperty("description_full")]
    public string DescriptionFull { get; set; }

    [JsonProperty("synopsis")]
    public string Synopsis { get; set; }

    [JsonProperty("yt_trailer_code")]
    public string YtTrailerCode { get; set ; }

    [JsonProperty("language")]
    public string Language { get; set; }

    [JsonProperty("mpa_rating")]
    public string MpaRating { get; set; }

    [JsonProperty("background_image")]
    public string BackgroundImage { get; set; }

    [JsonProperty("background_image_original")]
    public string BackgroundImageOriginal { get; set; }

    [JsonProperty("small_cover_image")]
    public string SmallCoverImage { get; set; }

    [JsonProperty("medium_cover_image")]
    public string MediumCoverImage { get; set; }

    [JsonProperty("large_cover_image")]
    public string LargeCoverImage { get; set; }

    [JsonProperty("state")]
    public string State { get; set; }

    [JsonProperty("torrents")]
    public List<Torrent> Torrents { get; set; }

    [JsonProperty("date_uploaded")]
    public string DateUploaded { get; set; }

    [JsonProperty("date_uploaded_unix")]
    public int DateUploadedUnix { get; set; }
}

public class Data
{
    [JsonProperty("movie_count")]
    public int MovieCount { get; set; }

    [JsonProperty("limit")]
    public int Limit { get; set; }

    [JsonProperty("page_number")]
    public int PageNumber { get; set; }

    [JsonProperty("movies")]
    public List<Movy> Movies { get; set; }
}

public class Meta
{
    [JsonProperty("server_time")]
    public int ServerTime { get; set; }

    [JsonProperty("server_timezone")]
    public string ServerTimezone { get; set; }

    [JsonProperty("api_version")]
    public int ApiVersion { get; set; }

    [JsonProperty("execution_time")]
    public string ExecutionTime { get; set; }
}

public class Root
{
    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("status_message")]
    public string StatusMessage { get; set; }

    [JsonProperty("data")]
    public Data Data { get; set; }

    [JsonProperty("@meta")]
    public Meta Meta { get; set; }
}

