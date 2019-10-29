﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Myles {
    public class Zone : Pattison.Zone {

        new static public ZoneInfo info = new ZoneInfo() {
            zoneName = "The Water Temple",
            creator = "Student Lastname",
            level = "MylesScene"
        };


        public AABB a;

        public AABB b;

        void Start()
        {

        }

        void Update() {
            if (a.CollidesWith(b))
            {
                a.GetComponent <MeshRenderer>().material.color = Color.red;
                b.GetComponent <MeshRenderer>().material.color = Color.red;

                Vector3 fix = a.FindFix(b);
                a.ApplyFix(fix);

            } else
            {
                a.GetComponent<MeshRenderer>().material.color = Color.white;
                b.GetComponent<MeshRenderer>().material.color = Color.white;
            }
        }


    }
}