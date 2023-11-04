using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecipeDisplay : MonoBehaviour
{
    Recipe recipe;

    public TMP_Text title;

    private void Start()
    {
        title.text = recipe.name;
    }
}
