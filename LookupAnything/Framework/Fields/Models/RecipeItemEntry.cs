using Pathoschild.Stardew.Common;
using StardewValley;

namespace Pathoschild.Stardew.LookupAnything.Framework.Fields.Models
{
    /// <summary>An input or output item for a recipe model.</summary>
    /// <param name="Sprite">The sprite to display.</param>
    /// <param name="DisplayText">The display text for the item name and count.</param>
    /// <param name="Quality">The item quality that will be produced, if applicable.</param>
    /// <param name="IsGoldPrice">Whether this is a gold price, rather than an ingredient.</param>
    internal record RecipeItemEntry(SpriteInfo? Sprite, string DisplayText, int? Quality, bool IsGoldPrice, bool IsBuilding = false, string? QualifiedItemId = null)
    {
        internal bool IsValid => this.IsBuilding || this.IsGoldPrice || this.QualifiedItemId == null || ItemRegistry.GetData(this.QualifiedItemId) != null;
    }
}
