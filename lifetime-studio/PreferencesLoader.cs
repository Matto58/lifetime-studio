using System.Diagnostics;

namespace lifetime_studio;

public class PreferencesLoader
{
	private static Dictionary<string, Dictionary<string, (int, int, int)>> darkThemes = new()
	{
		{ "purple", new() {
			{ "bgcolor", (23, 15, 31) },
			{ "bgcolortxtbox", (31, 23, 47) },
			{ "txtcolor", (255, 255, 255) }
		}},
		{ "blue", new() {
			{ "bgcolor", (15, 23, 31) },
			{ "bgcolortxtbox", (23, 23, 47) },
			{ "txtcolor", (255, 255, 255) }
		}},
		{ "green", new() {
			{ "bgcolor", (15, 31, 15) },
			{ "bgcolortxtbox", (23, 47, 23) },
			{ "txtcolor", (255, 255, 255) }
		}},
		{ "red", new() {
			{ "bgcolor", (31, 15, 15) },
			{ "bgcolortxtbox", (47, 15, 15) },
			{ "txtcolor", (255, 255, 255) }
		}},
	};
	private static Dictionary<string, Dictionary<string, (int, int, int)>> lightThemes = new()
	{
		{ "purple", new() {
			{ "bgcolor", (127, 63, 191) },
			{ "bgcolortxtbox", (191, 91, 255) },
			{ "txtcolor", (255, 255, 255) }
		}},
		{ "blue", new() {
			{ "bgcolor", (63, 63, 255) },
			{ "bgcolortxtbox", (91, 191, 255) },
			{ "txtcolor", (0, 0, 0) }
		}},
		{ "green", new() {
			{ "bgcolor", (91, 191, 63) },
			{ "bgcolortxtbox", (191, 255, 127) },
			{ "txtcolor", (0, 0, 0) }
		}},
		{ "red", new() {
			{ "bgcolor", (191, 31, 31) },
			{ "bgcolortxtbox", (255, 61, 61) },
			{ "txtcolor", (255, 255, 255) }
		}},
		{ "pink", new() {
			{ "bgcolor", (255, 63, 191) },
			{ "bgcolortxtbox", (255, 127, 255) },
			{ "txtcolor", (0, 0, 0) }
		}},
	};

	public static Dictionary<string, string>? Load()
	{
		if (!File.Exists("preferences.txt")) return null;
		return File.ReadAllLines("preferences.txt")
			.Select(l => l.Split('='))
			.Where(l => l.Length >= 2)
			.Select(l => (l[0], string.Join('=', l[1..])))
			.ToDictionary();
	}

	public static Dictionary<string, (int, int, int)>? LoadTheme(string id, bool light)
		=> light
			? (lightThemes.TryGetValue(id, out var t) ? t : null)
			: (darkThemes.TryGetValue(id, out t) ? t : null);
	
	public static Font? LoadFont(string val)
	{
		string[] s = val.Split(';');
		if (s.Length != 2) return null;
		if (!float.TryParse(s[1], out var size)) return null;
		return new(s[0], size);
	}

	public static void Store(Dictionary<string, string> preferences)
		=> File.WriteAllLines("preferences.txt", preferences.Select(p => p.Key + "=" + p.Value));

	public static List<string> GetLightThemes() => lightThemes.Select(k => k.Key).ToList();
	public static List<string> GetDarkThemes() => darkThemes.Select(k => k.Key).ToList();

	public static void CreateDefault() => File.WriteAllLines("preferences.txt",
	[
		"mode=dark",
		"theme=purple",
		"guifont=Segoe UI;9",
		"editfont=Consolas;12"
	]);
}
