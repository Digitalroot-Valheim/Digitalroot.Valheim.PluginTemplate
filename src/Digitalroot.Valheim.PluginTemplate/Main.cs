using BepInEx;
using Digitalroot.Valheim.Common;
using HarmonyLib;
using JetBrains.Annotations;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using UnityEngine;

namespace Digitalroot.Valheim.PluginTemplate
{
  [BepInPlugin(Guid, Name, Version)]
  [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
  public partial class Main : BaseUnityPlugin, ITraceableLogging
  {
    private Harmony _harmony;
    public static Main Instance;

    public Main()
    {
      Instance = this;
      #if DEBUG
      EnableTrace = true;
      Log.RegisterSource(Instance);
      #else
      EnableTrace = false;
      #endif
      Log.Trace(Main.Instance, $"{Main.Namespace}.{MethodBase.GetCurrentMethod().DeclaringType?.Name}.{MethodBase.GetCurrentMethod().Name}");
    }

    [UsedImplicitly]
    private void Awake()
    {
      try
      {
        Log.Trace(Main.Instance, $"{Main.Namespace}.{MethodBase.GetCurrentMethod().DeclaringType?.Name}.{MethodBase.GetCurrentMethod().Name}");
        _harmony = Harmony.CreateAndPatchAll(typeof(Main).Assembly, Guid);
      }
      catch (Exception e)
      {
        Log.Error(Instance, e);
      }
    }

    [UsedImplicitly]
    private void OnDestroy()
    {
      try
      {
        Log.Trace(Main.Instance, $"{Main.Namespace}.{MethodBase.GetCurrentMethod().DeclaringType?.Name}.{MethodBase.GetCurrentMethod().Name}");
        _harmony?.UnpatchSelf();
      }
      catch (Exception e)
      {
        Log.Error(Instance, e);
      }
    }

    public void OnSpawnedPlayer(ref Game game, Vector3 spawnPoint)
    {
      try
      {
        throw new NotImplementedException();
      }
      catch (Exception e)
      {
        Log.Error(Instance, e);
      }
    }

    public void OnZNetAwake(ref ZNet zNet)
    {
      try
      {
        throw new NotImplementedException();
      }
      catch (Exception e)
      {
        Log.Error(Instance, e);
      }
    }

    public void OnZNetSceneAwake(ref ZNetScene zNetScene)
    {
      try
      {
        throw new NotImplementedException();
      }
      catch (Exception e)
      {
        Log.Error(Instance, e);
      }
    }

    public void OnObjectDBCopyOtherDB(ref ObjectDB objectDB)
    {
      try
      {
        throw new NotImplementedException();
      }
      catch (Exception e)
      {
        Log.Error(Instance, e);
      }
    }

    public void OnObjectDBAwake(ref ObjectDB objectDB)
    {
      try
      {
        throw new NotImplementedException();
      }
      catch (Exception e)
      {
        Log.Error(Instance, e);
      }
    }

    #region Implementation of ITraceableLogging

    /// <inheritdoc />
    public string Source => Namespace;

    /// <inheritdoc />
    public bool EnableTrace { get; }

    #endregion
  }
}
