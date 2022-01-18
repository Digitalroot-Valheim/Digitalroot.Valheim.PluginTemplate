using System.Diagnostics.CodeAnalysis;

namespace Digitalroot.Valheim.PluginTemplate
{
  [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
  public partial class Main
  {
    public const string Version = "0.0.1";
    public const string Name = "Digitalroot Plug-in Template";
    public const string Guid = "digitalroot.mods.PluginTemplate";
    public const string Namespace = "Digitalroot.Valheim" + nameof(PluginTemplate);
  }
}
