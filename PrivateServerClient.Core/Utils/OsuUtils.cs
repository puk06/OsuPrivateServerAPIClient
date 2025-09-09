namespace PrivateServerClient.Core.Utils;

public static class OsuUtils
{
    private static readonly Dictionary<int, string> osu_mods = new()
    {
        { 0, "NM" },
        { 1, "NF" },
        { 2, "EZ" },
        { 4, "TD" },
        { 8, "HD" },
        { 16, "HR" },
        { 32, "SD" },
        { 64, "DT" },
        { 128, "RX" },
        { 256, "HT" },
        { 512, "NC" },
        { 1024, "FL" },
        { 2048, "AT" },
        { 4096, "SO" },
        { 8192, "RX2" },
        { 16384, "PF" },
        { 32768, "4K" },
        { 65536, "5K" },
        { 131072, "6K" },
        { 262144, "7K" },
        { 524288, "8K" },
        { 1048576, "FI" },
        { 2097152, "RD" },
        { 4194304, "CM" },
        { 8388608, "TP" },
        { 16777216, "9K" },
        { 33554432, "CP" },
        { 67108864, "1K" },
        { 134217728, "3K" },
        { 268435456, "2K" },
        { 536870912, "SV2" },
        { 1073741824, "MR" }
    };

    public static List<string> ParseMods(int mods)
    {
        List<string> activeModsShow = [];

        for (int i = 0; i < 32; i++)
        {
            int bit = 1 << i;
            if ((mods & bit) != bit) continue;
            activeModsShow.Add(osu_mods[bit]);
        }

        if (activeModsShow.Contains("NC") && activeModsShow.Contains("DT")) activeModsShow.Remove("DT");
        if (activeModsShow.Count == 0) activeModsShow.Add("NM");

        return activeModsShow;
    }
}
