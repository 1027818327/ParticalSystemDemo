
#region 版权信息
/*
 * -----------------------------------------------------------
 *  Copyright (c) KeJun All rights reserved.
 * -----------------------------------------------------------
 *		描述: 
 *      创建者：#DEVELOPERNAME#
 *      创建时间: #CREATIONDATE#
 *  
 */
#endregion


using UnityEngine;

namespace Demo1
{
    public class Test : MonoBehaviour
    {
        #region Fields
        public float mSize;
        public ParticleSystem mPs;
        public ParticleSystem.MainModule mModule;
        #endregion

        #region Properties

        #endregion

        #region Unity Messages
        //    void Awake()
        //    {
        //
        //    }
        //    void OnEnable()
        //    {
        //
        //    }
        //
        void Start()
        {
            mModule = mPs.main;
        }
        //    
        //    void Update() 
        //    {
        //    
        //    }
        //
        //    void OnDisable()
        //    {
        //
        //    }
        //
        //    void OnDestroy()
        //    {
        //
        //    }

        #endregion

        #region Private Methods
        [ContextMenu("SetSize")]
        private void SetSize()
        {
            /*
            var temp = mPs.main;
            temp.startSize = mSize;
            */

            mModule.startSize = mSize;
        }
        #endregion

        #region Protected & Public Methods

        #endregion
    }
}