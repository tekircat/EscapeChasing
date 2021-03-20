using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YolDeneme : MonoBehaviour
{
    public int yolSayisi = 4;

    public Transform yolPrefab;

    private Transform[] yollar;
    public Transform kamera;

    private int bastakiYol;

    private float yolUzunluk;

    void Start()
    {
        kamera = Camera.main.transform;
        yollar = new Transform[yolSayisi];
        bastakiYol = 0;

        yolUzunluk = yolPrefab.GetComponent<MeshFilter>().sharedMesh.bounds.size.z * yolPrefab.localScale.z;
        for (int i = 0; i < yolSayisi; i++)
        {
            Vector3 pozisyon = new Vector3(0, 0, i * yolUzunluk);
            yollar[i] = Instantiate(yolPrefab, pozisyon, Quaternion.identity);
        }
    }

    void Update()
    {
        float kameraZ = kamera.position.z;
        float bastakiYolZ = yollar[bastakiYol].position.z;

        if (kameraZ >= bastakiYolZ + 2f * yolUzunluk)
        {
            yollar[bastakiYol].position += new Vector3(0, 0, yolUzunluk * yolSayisi);

            bastakiYol++;
            if (bastakiYol >= yolSayisi)
                bastakiYol = 0;
        }
        else if (kameraZ < bastakiYolZ + yolUzunluk * 0.5f)
        {
            int sondakiYol = (bastakiYol + yolSayisi - 1) % yolSayisi;
            yollar[sondakiYol].position -= new Vector3(0, 0, yolUzunluk * yolSayisi);

            bastakiYol--;
            if (bastakiYol < 0)
                bastakiYol = yolSayisi - 1;
        }
    }
}

