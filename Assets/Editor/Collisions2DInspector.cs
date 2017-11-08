using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Collisions))]
public class Collisions2DInspector : Editor
{
    static bool stateFoldOut = true;
    bool drawDefaultInspector;


    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Collisions col = (Collisions)target;

        GUIStyle booleanText = new GUIStyle();

        EditorGUILayout.Space();
        EditorGUI.indentLevel = 5;

        EditorGUILayout.Foldout(stateFoldOut, "State", true, EditorStyles.toolbar);

        //EditorGUILayout.Toggle("Is Grounded", col.isGrounded); // Asi sale como por defecto

        if(stateFoldOut)
        {
            EditorGUI.indentLevel = 2;

            EditorGUILayout.BeginVertical(EditorStyles.textArea);

            if(col.isGrounded) booleanText.normal.textColor = Color.green;
            else booleanText.normal.textColor = Color.red;
            EditorGUILayout.LabelField("Is Grounded", booleanText);


            if(col.wasGroundedLastFrame) booleanText.normal.textColor = Color.green;
            else booleanText.normal.textColor = Color.red;
            EditorGUILayout.LabelField("wasGroundedLastFrame", booleanText);

            if(col.justGotGrounded) booleanText.normal.textColor = Color.green;
            else booleanText.normal.textColor = Color.red;
            EditorGUILayout.LabelField("justGotGrounded", booleanText);

            if(col.justNOTGrounded) booleanText.normal.textColor = Color.green;
            else booleanText.normal.textColor = Color.red;
            EditorGUILayout.LabelField("justNOTGrounded", booleanText);

            if(col.isFalling) booleanText.normal.textColor = Color.green;
            else booleanText.normal.textColor = Color.red;
            EditorGUILayout.LabelField("isFalling", booleanText);

            if(col.isTouchingWall) booleanText.normal.textColor = Color.green;
            else booleanText.normal.textColor = Color.red;
            EditorGUILayout.LabelField("isTouchingWall", booleanText);

            if(col.wasTouchingWallLastFrame) booleanText.normal.textColor = Color.green;
            else booleanText.normal.textColor = Color.red;
            EditorGUILayout.LabelField("wasTouchingWallLastFrame", booleanText);

            if(col.justTouchingWall) booleanText.normal.textColor = Color.green;
            else booleanText.normal.textColor = Color.red;
            EditorGUILayout.LabelField("justTouchingWall", booleanText);

            if(col.justNOTTouchingWall) booleanText.normal.textColor = Color.green;
            else booleanText.normal.textColor = Color.red;
            EditorGUILayout.LabelField("justNotTouchingWall", booleanText);

            if(col.isTouchingCeil) booleanText.normal.textColor = Color.green;
            else booleanText.normal.textColor = Color.red;
            EditorGUILayout.LabelField("isTouchingCeil", booleanText);

            if(col.wasTouchingCeilLastFrame) booleanText.normal.textColor = Color.green;
            else booleanText.normal.textColor = Color.red;
            EditorGUILayout.LabelField("wasTouchingWallLastFrame", booleanText);

            if(col.justTouchingCeilLastFrame) booleanText.normal.textColor = Color.green;
            else booleanText.normal.textColor = Color.red;
            EditorGUILayout.LabelField("justTouchingCeilLastFrame", booleanText);

            if(col.justNOTTouchingCeil) booleanText.normal.textColor = Color.green;
            else booleanText.normal.textColor = Color.red;
            EditorGUILayout.LabelField("justNotTouchinWall", booleanText);

            EditorGUILayout.EndVertical();
        

        }
       
       

      
    }
	
}
