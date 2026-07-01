using PurePatcher.Annotations;

namespace Kingfisher.Prepatching;

public static class InjectedThingCompFields {
    [AddField]
    [BindComponent]
    public static extern CompExplosive? ExplosiveComp(this ThingWithComps target);

    [AddField]
    [BindComponent]
    public static extern CompPowerTrader? PowerTraderComp(this ThingWithComps target);

    [AddField]
    [BindComponent]
    public static extern CompUniqueWeapon? UniqueWeaponComp(this ThingWithComps target);
}