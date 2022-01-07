﻿using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPortraitVisual : MonoBehaviour
{
    public CharacterAsset charAsset;
    [Header("Text Component References")]
    //public Text NameText;
    public Text HealthText;
    [Header("Image References")]
    public Image HeroPowerIconImage;
    public Image HeroPowerBackgroundImage;
    public Image PortraitImage;
    public Image PortraitBackgroundImage;

    void Awake()
    {
        if (charAsset != null) ApplyLookFromAsset();
    }

    public void ApplyLookFromAsset()
    {
        HealthText.text = charAsset.MaxHealth.ToString();
        HeroPowerIconImage.sprite = charAsset.HeroPowerIconImage;
        HeroPowerBackgroundImage.sprite = charAsset.HeroPowerBGImage;
        PortraitImage.sprite = charAsset.AvatarImage;
        PortraitBackgroundImage.sprite = charAsset.AvatarBGImage;

        HeroPowerBackgroundImage.color = charAsset.HeroPowerBGTint;
        PortraitBackgroundImage.color = charAsset.AvatarBGTint;

    }

    public void TakeDamage(int amount, int healthAfter)
    {
        if (amount > 0)
        {
            // TODO DamageEffect.CreateDamageEffect(transform.position, amount);
            HealthText.text = healthAfter.ToString();
        }
    }

    public void Explode()
    {
        /* TODO
        Instantiate(GlobalSettings.Instance.ExplosionPrefab, transform.position, Quaternion.identity);
        Sequence s = DOTween.Sequence();
        s.PrependInterval(2f);
        s.OnComplete(() => GlobalSettings.Instance.GameOverCanvas.SetActive(true));
        */
    }



}
