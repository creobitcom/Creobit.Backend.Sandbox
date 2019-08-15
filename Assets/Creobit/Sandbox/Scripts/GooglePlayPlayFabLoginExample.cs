﻿using UnityEngine;

namespace Creobit.Backend
{
    [DisallowMultipleComponent]
    public sealed class GooglePlayPlayFabLoginExample : MonoBehaviour
    {
        #region MonoBehaviour

        private void Awake()
        {
            var playFabAuth = new PlayFabAuth(_titleId);
            var googlePlayAuth = new GooglePlayAuth();
            var googlePlayPlayFabAuth = new GooglePlayPlayFabAuth(playFabAuth, googlePlayAuth);

            _auth = googlePlayPlayFabAuth;
        }

        private void Start()
        {
            _auth.Login(
                () =>
                {
                    Debug.Log("Auth.Login: Complete");
                },
                () =>
                {
                    Debug.LogError("Auth.Login: Failure");
                });
        }

        #endregion
        #region GooglePlayPlayFabLoginExample

        private IAuth _auth;

        [Header("PlayFab")]

        [SerializeField]
        private string _titleId = "12513";

        #endregion
    }
}