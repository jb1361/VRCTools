﻿using System;
using UnityEngine;
using VRC.Core;
using VRCModLoader;

namespace VRCTools
{
    public static class VRCFlowManagerUtils
    {
        public static void DisableVRCFlowManager()
        {
            VRCModLogger.Log("[VRCFlowManagerUtils] Looking for VRCFlowManager");
            VRCFlowManager[] flowManagers = Resources.FindObjectsOfTypeAll<VRCFlowManager>();
            foreach (VRCFlowManager flowManager in flowManagers)
            {
                flowManager.enabled = false;
            }
            VRCModLogger.Log("[VRCFlowManagerUtils] Disabled " + flowManagers.Length + " VRCFlowManager");
            
            if (GameObject.Find("UserInterface") == null)
            {
                VRCModLogger.Log("[VRCToolsUpdater] Loading additive scene \"ui\"");
                AssetManagement.LoadLevelAdditive("ui");
            }
        }

        internal static void EnableVRCFlowManager()
        {
            VRCModLogger.Log("[VRCFlowManagerUtils] Looking for VRCFlowManager");
            VRCFlowManager[] flowManagers = Resources.FindObjectsOfTypeAll<VRCFlowManager>();
            foreach (VRCFlowManager flowManager in flowManagers)
            {
                flowManager.enabled = true;
            }
            VRCModLogger.Log("[VRCFlowManagerUtils] Enabled " + flowManagers.Length + " VRCFlowManager");
        }
    }
}