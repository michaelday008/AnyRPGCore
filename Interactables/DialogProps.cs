using AnyRPG;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace AnyRPG {

    [System.Serializable]
    public class DialogProps : InteractableOptionProps {

        [Header("Dialog")]

        [Tooltip("The names of the dialogs available to this interactable")]
        [SerializeField]
        private List<string> dialogNames = new List<string>();

        public override Sprite Icon { get => (SystemConfigurationManager.MyInstance.MyDialogInteractionPanelImage != null ? SystemConfigurationManager.MyInstance.MyDialogInteractionPanelImage : base.Icon); }
        public override Sprite NamePlateImage { get => (SystemConfigurationManager.MyInstance.MyDialogNamePlateImage != null ? SystemConfigurationManager.MyInstance.MyDialogNamePlateImage : base.NamePlateImage); }
        public List<string> DialogNames { get => dialogNames; set => dialogNames = value; }

        public override InteractableOptionComponent GetInteractableOption(Interactable interactable) {
            return new DialogComponent(interactable, this);
        }
    }

}