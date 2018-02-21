using System;
using System.Collections.Generic;

namespace spacex_bot.responses
{
    public class Core
    {
        public string core_serial { get; set; }
        public int? flight { get; set; }
        public int? block { get; set; }
        public bool reused { get; set; }
        public bool? land_success { get; set; }
        public string landing_type { get; set; }
        public string landing_vehicle { get; set; }
    }

    public class FirstStage
    {
        public List<Core> cores { get; set; }
    }

    public class Payload
    {
        public string payload_id { get; set; }
        public bool reused { get; set; }
        public List<string> customers { get; set; }
        public string payload_type { get; set; }
        public int? payload_mass_kg { get; set; }
        public double? payload_mass_lbs { get; set; }
        public string orbit { get; set; }
        public string cap_serial { get; set; }
        public double? mass_returned_kg { get; set; }
        public int? mass_returned_lbs { get; set; }
        public int? flight_time_sec { get; set; }
        public string cargo_manifest { get; set; }
    }

    public class SecondStage
    {
        public List<Payload> payloads { get; set; }
    }

    public class Rocket
    {
        public string rocket_id { get; set; }
        public string rocket_name { get; set; }
        public string rocket_type { get; set; }
        public FirstStage first_stage { get; set; }
        public SecondStage second_stage { get; set; }
    }

    public class Telemetry
    {
        public string flight_club { get; set; }
    }

    public class Reuse
    {
        public bool core { get; set; }
        public bool side_core1 { get; set; }
        public bool side_core2 { get; set; }
        public bool fairings { get; set; }
        public bool capsule { get; set; }
    }

    public class LaunchSite
    {
        public string site_id { get; set; }
        public string site_name { get; set; }
        public string site_name_long { get; set; }
    }

    public class Links
    {
        public string mission_patch { get; set; }
        public string article_link { get; set; }
        public string video_link { get; set; }
        public string presskit { get; set; }
        public string reddit_campaign { get; set; }
        public string reddit_launch { get; set; }
        public string reddit_recovery { get; set; }
        public string reddit_media { get; set; }
    }

    public class Launch
    {
        public int flight_number { get; set; }
        public string launch_year { get; set; }
        public int launch_date_unix { get; set; }
        public DateTime launch_date_utc { get; set; }
        public DateTime launch_date_local { get; set; }
        public Rocket rocket { get; set; }
        public Telemetry telemetry { get; set; }
        public Reuse reuse { get; set; }
        public LaunchSite launch_site { get; set; }
        public bool? launch_success { get; set; }
        public Links links { get; set; }
        public string details { get; set; }
    }
}