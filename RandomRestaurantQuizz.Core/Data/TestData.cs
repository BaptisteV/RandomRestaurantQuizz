namespace RandomRestaurantQuizz.Core.Data;

public static class TestData
{
    public static string JsonDij { get; } =
"""
{
  "places": [
    {
      "formattedAddress": "2 Rue Bannelier, 21000 Dijon, France",
      "rating": 3.8,
      "userRatingCount": 452,
      "displayName": {
        "text": "Carrefour City",
        "languageCode": "fr"
      },
      "reviews": [
        {
          "name": "places/ChIJE4gvz-6d8kcRFHxIsV4AS2Q/reviews/Ci9DQUlRQUNvZENodHljRjlvT2t0U1VHSjNXR2RVVDBFdE9VOXFlVlZ3TkZSVVZXYxAB",
          "relativePublishTimeDescription": "4 months ago",
          "rating": 4,
          "text": {
            "text": "Its small, but very central. And get all you need. Opening times are good and staff is friendly.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Its small, but very central. And get all you need. Opening times are good and staff is friendly.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "R. Ant",
            "uri": "https://www.google.com/maps/contrib/100647282829783612135/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocKWSeeRiT3xoVU-uLkXVWS7VGA1LLnH0oJT2cXg7ak7YALwtQ=s128-c0x00000000-cc-rp-mo-ba6"
          },
          "publishTime": "2025-09-14T10:32:19.881250842Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2t0U1VHSjNXR2RVVDBFdE9VOXFlVlZ3TkZSVVZXYxAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2t0U1VHSjNXR2RVVDBFdE9VOXFlVlZ3TkZSVVZXYxAB!2m1!1s0x47f29deecf2f8813:0x644b005eb1487c14",
          "visitDate": {
            "year": 2025,
            "month": 9
          }
        },
        {
          "name": "places/ChIJE4gvz-6d8kcRFHxIsV4AS2Q/reviews/ChZDSUhNMG9nS0VJQ0FnSUNKbXRubkF3EAE",
          "relativePublishTimeDescription": "2 years ago",
          "rating": 5,
          "text": {
            "text": "It’s a good supermarket with reasonable price.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "It’s a good supermarket with reasonable price.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Kunihiko KORIYAMA",
            "uri": "https://www.google.com/maps/contrib/118200569625456809047/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUFjD8UKdz90eXR8rVOuYB6z2ns7DLxJXRomvP_fLHrZrMqklk=s128-c0x00000000-cc-rp-mo-ba3"
          },
          "publishTime": "2023-06-25T10:41:35.111841Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChZDSUhNMG9nS0VJQ0FnSUNKbXRubkF3EAE&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChZDSUhNMG9nS0VJQ0FnSUNKbXRubkF3EAE!2m1!1s0x47f29deecf2f8813:0x644b005eb1487c14",
          "visitDate": {
            "year": 2023,
            "month": 6
          }
        },
        {
          "name": "places/ChIJE4gvz-6d8kcRFHxIsV4AS2Q/reviews/Ci9DQUlRQUNvZENodHljRjlvT2tocWRVWk5aR2x2U1ZoS1VXMDFabE40Y1hCTFlXYxAB",
          "relativePublishTimeDescription": "7 months ago",
          "rating": 3,
          "text": {
            "text": "Good store with nice service. Not a huge variety but good for weekly groceries.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Good store with nice service. Not a huge variety but good for weekly groceries.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Linnea Jämsä",
            "uri": "https://www.google.com/maps/contrib/115088664839561124961/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXN6eylwbC2t9rxlL5tycuBZgDz42HSHQZCL6MYMp-uWLT82OjM=s128-c0x00000000-cc-rp-mo-ba4"
          },
          "publishTime": "2025-06-18T12:19:56.107000409Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2tocWRVWk5aR2x2U1ZoS1VXMDFabE40Y1hCTFlXYxAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2tocWRVWk5aR2x2U1ZoS1VXMDFabE40Y1hCTFlXYxAB!2m1!1s0x47f29deecf2f8813:0x644b005eb1487c14",
          "visitDate": {
            "year": 2025,
            "month": 6
          }
        },
        {
          "name": "places/ChIJE4gvz-6d8kcRFHxIsV4AS2Q/reviews/ChZDSUhNMG9nS0VJQ0FnSURRdExERU9nEAE",
          "relativePublishTimeDescription": "7 years ago",
          "rating": 4,
          "text": {
            "text": "Open Sundays with a great selection of fresh and ambient produce. The prices are fare considering the conviennce and the staff offered a decent service. It does have a tendency to get super busy here at times, given its location and favourable opening hours.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Open Sundays with a great selection of fresh and ambient produce. The prices are fare considering the conviennce and the staff offered a decent service. It does have a tendency to get super busy here at times, given its location and favourable opening hours.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "B N",
            "uri": "https://www.google.com/maps/contrib/103593926999723334959/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWFr_LTYDDHVwfj4RvCHUUgVma1XPbLQPd6WgwmCJksPjCzIIYboA=s128-c0x00000000-cc-rp-mo-ba6"
          },
          "publishTime": "2018-05-21T07:28:01.562Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChZDSUhNMG9nS0VJQ0FnSURRdExERU9nEAE&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChZDSUhNMG9nS0VJQ0FnSURRdExERU9nEAE!2m1!1s0x47f29deecf2f8813:0x644b005eb1487c14"
        },
        {
          "name": "places/ChIJE4gvz-6d8kcRFHxIsV4AS2Q/reviews/ChZDSUhNMG9nS0VJQ0FnSUN3bDl2bUNnEAE",
          "relativePublishTimeDescription": "7 years ago",
          "rating": 4,
          "text": {
            "text": "Was super glad to find it - had everything we were looking for. Our dog was thrilled that it had Pedigree DentaStix (& not another brand's fake ones. She doesn't like them, spoiled animal!), loved the Carrefour dry snacks, and we were happy that the giant can of wet food for her cost 1.02€, which is cheaper (& more loved!) than any other \"special treat\" food. Lost a star for changing its closing hours which screwed us over by a mere 5 minutes the 2nd time we came by (21:50 instead of 22:00 on a placard glued over the glass window with the hours painted on). We understand why, and how it's hard to kick people out on time, but then why not just stay open a little longer instead? Say 22:15?",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Was super glad to find it - had everything we were looking for. Our dog was thrilled that it had Pedigree DentaStix (& not another brand's fake ones. She doesn't like them, spoiled animal!), loved the Carrefour dry snacks, and we were happy that the giant can of wet food for her cost 1.02€, which is cheaper (& more loved!) than any other \"special treat\" food. Lost a star for changing its closing hours which screwed us over by a mere 5 minutes the 2nd time we came by (21:50 instead of 22:00 on a placard glued over the glass window with the hours painted on). We understand why, and how it's hard to kick people out on time, but then why not just stay open a little longer instead? Say 22:15?",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "PandH",
            "uri": "https://www.google.com/maps/contrib/112880177414364269279/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocKLSL_sB4HsgRD_lbMP-msIwmocTWDYiMmMrlaNGvewnMy9ew=s128-c0x00000000-cc-rp-mo-ba4"
          },
          "publishTime": "2018-09-20T06:52:48.690088Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChZDSUhNMG9nS0VJQ0FnSUN3bDl2bUNnEAE&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChZDSUhNMG9nS0VJQ0FnSUN3bDl2bUNnEAE!2m1!1s0x47f29deecf2f8813:0x644b005eb1487c14"
        }
      ],
      "photos": [
        {
          "name": "places/ChIJE4gvz-6d8kcRFHxIsV4AS2Q/photos/AcnlKN2qSZLNXUpmGBtQWxpo8I3tlKG89Yqbf_2o8LBdh6w3uEvLOMMWuqShjKNXfdq1IrgP5gpxc3sG-PqTHWjGT_cgjchz5PwQJLNOF0UQZZccve3yfDKGI3T-0_XHZiIojv2s4-y2H_o9w2AnScAFMJxDtqa6JLbElIG3C9T2aAwNuXZaUO4JkiBHVQef6UccGvvmAGFTcc8uiHR_jB7htY__9dh6r6wLxLA-k5An_YBkit9JB4DR0ErV6QWGBaeFkqpr7x-y-LaNrkLhp1PMXx-XEcOQfQqZJtczwfBE8zN0WQ",
          "widthPx": 2016,
          "heightPx": 1134,
          "authorAttributions": [
            {
              "displayName": "Carrefour City",
              "uri": "https://maps.google.com/maps/contrib/112237233507683497571",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjX_pqMGu7BWqIrIngDliLd5WyGHh_w2vzL8T7fnLhs0VuxHcCJM=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipMLcRgbt1ggWWll7FWJYtL6pKlahxgOruHRm9vy&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipMLcRgbt1ggWWll7FWJYtL6pKlahxgOruHRm9vy!2e10!4m2!3m1!1s0x47f29deecf2f8813:0x644b005eb1487c14"
        },
        {
          "name": "places/ChIJE4gvz-6d8kcRFHxIsV4AS2Q/photos/AcnlKN3E9zmc5UQWvMfC1cgNUsZVfYMhPJMhYGwlNI4738Bmi5ZgWom3WS5pHoXg-xyoxVTPB2n3QwOx7ej_XQFoIRn_8b57MVLWW9VyskJOx4YmAqKadH9ypWLOJkc9DLXLdomJJc_KyaKJH1l_sAXsjmxKAdtrBrpvqYq4yaaGTltyFCGn-oaVnBiA7VhKDu75_KjTx21yXjjqio2ZAXGgGxvwVVQPl9er1koZUdRzwAh9kYJi3dn4M77_pjTO2MzaHFk7hXUp8lMAqafRZoFYZkl6lqLqpmuRMghKe9Xe65TOuZ7XX0M_yhEYSAK-jXcsy_QEoN3W6QTup9YV_JNGM2xst0jsGWDP3VVjYRkOZyQKNUB38yw4xInN_5o2F_yniS1FVDogtPOsfELA8oqrgEsHjLE2doqGlfhmjJXr_QPYZG0",
          "widthPx": 4032,
          "heightPx": 3024,
          "authorAttributions": [
            {
              "displayName": "Ricardo Lasa",
              "uri": "https://maps.google.com/maps/contrib/114740239522014127971",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWaPjtMl4UWZLSceb63cWOdqVm2gkOohYpQrHMdRdxHvXAN97iS=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgICkqJTfuwE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgICkqJTfuwE!2e10!4m2!3m1!1s0x47f29deecf2f8813:0x644b005eb1487c14"
        },
        {
          "name": "places/ChIJE4gvz-6d8kcRFHxIsV4AS2Q/photos/AcnlKN1VdNM9Ije0WeDESc_pBxYXSh67w6gXR0huazRehYL9dUV33EQNeVMsHesf9OjIJxX7Y0ozq3wPOatswcSiu3NF_9zbGQ5hUlUhmPdCp0jsGrmoBKMLqJ2AkF7yWj9ZwdSPZfrpvdWtRVqQcpo9JqaLMybaoOFsutEEEifXkDBk5MNWYyoqRXFpNgW0rDYCvK2I-vj6iJzLWAMIMMYscbqgDGK1znYck1O-xOoHThNrNtrG4MFP-6FJCM5uWRw32oVBUxDYcRZdYhu1d_L90HMCA2GCvwL3qL60l4M_mdFY_-dRlRVc54MWewrtKMJ0ihQOiEGgOAaE2YV_hKpQEJc8JObYR2gHEigKyWG7yvmeq84H0GT-_J9FHN2zxvVYsymG1Q6uppZ1xu3NSMln9z4ttm0NLAaYEqpZ5r0LEsXjRGjp",
          "widthPx": 4160,
          "heightPx": 3120,
          "authorAttributions": [
            {
              "displayName": "M Amghar",
              "uri": "https://maps.google.com/maps/contrib/112613021428702596168",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjU7w67AbTRcE4Yb2vQHc6ngOqhxCFFZi2pbyvdo2kYM_85h2h2O=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgIDcr9jWkgE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgIDcr9jWkgE!2e10!4m2!3m1!1s0x47f29deecf2f8813:0x644b005eb1487c14"
        },
        {
          "name": "places/ChIJE4gvz-6d8kcRFHxIsV4AS2Q/photos/AcnlKN3bHy54MnRdHN3BWks6X9fX44mPbgNnm11CzgncE1evjvafnb4bwQTbS5NN6Pd8m7e3wnoqK1thIbQK86lqnc9YVsMP960FA39rn58skNNuytWLONWRlgAayG0Jp8qyCeHlsu41ipWb-sKuAXZvFXVimTktfXbA3sFycAcVAkcYZdQsy1VoU9nWWbwBaCOFxbsxqd9CDauqgXheWKZ8F55pruFzTnl2yuT39GrgXnQt3ZBUtFcD1RZRui9-X_VjhN5i9J0LmTdCRai5ZRgx_0mbUSC_9uHc89e-5A8MQ31_yc2556Z0vWdqvxBDPbKMhG9J7Z4uuWtVbTzi14d4NS2dYiqxDkA2HOVnHnlSjAcpLqY0elsQN7tM8I3K9y7s59xJ_rk3xhhcZrIaUrPOdIi_j8ZM6SGWYtwqVUjiifuyzajH",
          "widthPx": 1440,
          "heightPx": 1440,
          "authorAttributions": [
            {
              "displayName": "Halis Ekizceli",
              "uri": "https://maps.google.com/maps/contrib/100937773863800109135",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUTG7ZdjGFfsDLuV5GlG3qQ8lI0EFBw7Y4aq50GALeNzSkOS1U=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgIDqnvnv_wE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgIDqnvnv_wE!2e10!4m2!3m1!1s0x47f29deecf2f8813:0x644b005eb1487c14"
        },
        {
          "name": "places/ChIJE4gvz-6d8kcRFHxIsV4AS2Q/photos/AcnlKN2hTNQ_QodhRjDMtFqSz_PQorzrMwygSYN2l5e3dXlgJNK_AI7SghKdhpdBF8bWbTKy30LGmFJXXVxkCqfkmS7-88snucRafs_o1KsjhuC_4V4I-YGjAr6DrU9o3xIJKaLsgnrNWksUAsP2MNgjX4c1S2-R1uvM5uGaMR9z8VprMDqhlNZoTF5Hlp1mvA8alat56ATsQnwjEe3QJOE6IRn1kBZnbc4lirjrJk1rYGyZ1Lvqxvfc9iCGg7d5hxSHVtkM0r6vmwoZuhEYbAV3sy7Oyz16L3hLJ65lCH-TdovBFw",
          "widthPx": 1512,
          "heightPx": 2016,
          "authorAttributions": [
            {
              "displayName": "Carrefour City",
              "uri": "https://maps.google.com/maps/contrib/112237233507683497571",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjX_pqMGu7BWqIrIngDliLd5WyGHh_w2vzL8T7fnLhs0VuxHcCJM=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipONqjmqPbqHiBtlJt0ofWnw8jaqhm_9flPsA5A4&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipONqjmqPbqHiBtlJt0ofWnw8jaqhm_9flPsA5A4!2e10!4m2!3m1!1s0x47f29deecf2f8813:0x644b005eb1487c14"
        },
        {
          "name": "places/ChIJE4gvz-6d8kcRFHxIsV4AS2Q/photos/AcnlKN08WzMcaMbmRtedXEN3UPYC1xYFWvAKKt_NUKIWRfb_Y5WAXEnSy7yFaU3LEBn8si_YUBR_IF7RU9ujY84Mh74vAlIpzRgxAdR5K20SEP9XqEgSn6HQspiw7fxzqdMJ7R1HVaMaFk7FkpXqe2TJ_rqwTeRFnBfEsqXAKHLdNdZsKmu2XRLRL3gQml557gTDrpyaZJXQTVqLbeKHYgbvLBOHzamYkhWAmRznPV0lVz0_2lu9uIXGwwlUeSj3JlWuiXuLZeo_5jYX84LULocYKptI3KGASO3VaK7L_cBL_ilTXrhmqgs8XQ8ixfceQqqmbdDRdB6ZMz4vnSV-7uZ2-0lpNdj2zS9xsUQgFVO8dGTEhL1_uFK-xFj1-j0D3E1Q_XcHxswCoyMzpcQAYHAiaYX89jDm0MNTs1R2kINa7h2juQ",
          "widthPx": 4160,
          "heightPx": 3120,
          "authorAttributions": [
            {
              "displayName": "M Amghar",
              "uri": "https://maps.google.com/maps/contrib/112613021428702596168",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjU7w67AbTRcE4Yb2vQHc6ngOqhxCFFZi2pbyvdo2kYM_85h2h2O=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgIDcr4S3eg&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgIDcr4S3eg!2e10!4m2!3m1!1s0x47f29deecf2f8813:0x644b005eb1487c14"
        },
        {
          "name": "places/ChIJE4gvz-6d8kcRFHxIsV4AS2Q/photos/AcnlKN22JBrbb5oJc8DCeXWak8cEfwX4U00-ZbnsIe5ljtlO8vPom-X_P9pN2_SfXws4jXpLLrpvTGHZqGtx7LF_uQNjZ-KHy225hQS3fT7Mkd2OZzZ7_EZbOo_F-rhxEoeXudmIX68Dv3d9XqzTevAPk_jY_Fs5IMWq0yHzIB5IczGn21R0HoYgSRz-z2UkFNc-Kbir3J-EXdbnXWZ-nhKsjJgzku-AoEYZg6s7vNCdfm7GHMkzwdrtN5nMGzuidxTU_vy4NWqJPbcmAJY8WuP0uvWNozZL9iFtF2NlZpH0LYObAfForcFzuKaUeNUSypK2uEmknQ1eMe3D7vndOmfoHBVZDUY_5tGzhNvxI-EZIbhMoOwe5PNQTQvKqTLPC6E3RNrAvbKwlYOjyDlBCWmxPEBlGCoHjjkhoC6buEXa8Ks",
          "widthPx": 4032,
          "heightPx": 3024,
          "authorAttributions": [
            {
              "displayName": "Ricardo Lasa",
              "uri": "https://maps.google.com/maps/contrib/114740239522014127971",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWaPjtMl4UWZLSceb63cWOdqVm2gkOohYpQrHMdRdxHvXAN97iS=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgICkqLSkZA&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgICkqLSkZA!2e10!4m2!3m1!1s0x47f29deecf2f8813:0x644b005eb1487c14"
        },
        {
          "name": "places/ChIJE4gvz-6d8kcRFHxIsV4AS2Q/photos/AcnlKN2ZEVM_lAxOMAD_uZ6tPPpv_X99OfacXHr4ksYXTg-ijUDPQ6Bxo5MXVxiVDLxgzmB-Tf_p7ayz7BciptkAA5Pm98apfYiJl1A4KiK6kxM5RsfB-Dmgitd6zPMHkjkRKdDHe0Rof6qY_swOYvzvPeTi7K42lvvcWze4wmqr-LfQlgLMVUEp_izLYc7-2UT0Xg4uTnf5T899mCj52txMmlc2um2tRM_w1SF3wgEj5p7eUToy_X1pNSSMXajxzR1w923XEH3M5big9zRQJywIUtorhqEIrRJ2LgrX7lTZOyBAjZNvBvAZ2ttn_Da_EoMFyL7BNPHvg1TbyzoHkFdvp7XuZyUrHKkI1lUfszFLejXdPTcK0YA6IV-YoLfOFjySV8JftVOd4NNfhVmrEw06_DWgEFhsYBgnKhKYKputJJSq9bwr",
          "widthPx": 3024,
          "heightPx": 4032,
          "authorAttributions": [
            {
              "displayName": "Halis Ekizceli",
              "uri": "https://maps.google.com/maps/contrib/100937773863800109135",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUTG7ZdjGFfsDLuV5GlG3qQ8lI0EFBw7Y4aq50GALeNzSkOS1U=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgICXxcO6pgE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgICXxcO6pgE!2e10!4m2!3m1!1s0x47f29deecf2f8813:0x644b005eb1487c14"
        },
        {
          "name": "places/ChIJE4gvz-6d8kcRFHxIsV4AS2Q/photos/AcnlKN0ZtmVk14Ed5pskaZHtKKE1zEQ7u7BSq8Bjdbp6e8VX93aUCtUh0lEPL7xATSUr-s1fo06dNy068EjR7Hu5usXuh7W_Da72yHQncEzN43BLXqRsT4r0okVynbVOmU_fI_Em2PfPoa5wRrykrrtLcKN69lbRtf11Tgv_5E7hg6xA2qlKbaIhlQVy-MQi0NUPaRMzLizwEzy2VrUCzCYyPon76d4atnLXmJGPwexWlM5-TquJRPjvJPjqtwlp1XZUNcpdjkqq1kaV8ntpXus_ff71wF5OlKmGe5PPn8_kob76VQ3DJPaeHfbSPBP4Tz9m5-lQaQwIvyunQRxrzsHUDEWcKUFwWZYXS8VWXTz8h78fefNdwS6W-xQQezEOveO8ngwOdbnvkin-PPhGnL6LzesD4Iwanf-gav10n0H5rvna2O9s",
          "widthPx": 1920,
          "heightPx": 1080,
          "authorAttributions": [
            {
              "displayName": "Romain Cendre",
              "uri": "https://maps.google.com/maps/contrib/112923747094026774833",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUdDD4uRGfuueeARW_LMTtoWHSLDcDG-_r0uF8nuVupKaDwofFS7Q=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgICEk8LIvQE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgICEk8LIvQE!2e10!4m2!3m1!1s0x47f29deecf2f8813:0x644b005eb1487c14"
        },
        {
          "name": "places/ChIJE4gvz-6d8kcRFHxIsV4AS2Q/photos/AcnlKN1Jy69yTPm8OxFx9KoEdYo3uuQNKFReQAXIaeDWmYbGvuh6crkg1LspRfuSUB6zB5yuyyyX9QtppNcNdWRfMLs_Pl6CICC1VpPVWk_-D99aXQEiedYjYSdVnRhffhqKqQxwJhE0yyYmt3eGXXBVdo1FPJ_-zqydmJc0h3gg6Ca60HtaaBUTrBeiYxdIsxOnkJ7t-SpKV9CPyTVOtJsE3CUEWLYnL_oDLFulhZpktHFceZXeiIyn-c1z-LTkQMP7CSbdX18oi_zsC6QXerYrunn3PTfVP25Tghijs7RmyqDnBAFjwspkQrZrB6ym6WpO00Vk3AQK77MtumjXJ1tevoL0ifjCD20iUVb-yRVq91WKfyUhwGIuh381PTsL5SGXJF6yZZmvsZTj7l1_xMIKSBjJ0zBYee4P9fKLt_g-fHJaoQ",
          "widthPx": 3024,
          "heightPx": 4032,
          "authorAttributions": [
            {
              "displayName": "Halis Ekizceli",
              "uri": "https://maps.google.com/maps/contrib/100937773863800109135",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUTG7ZdjGFfsDLuV5GlG3qQ8lI0EFBw7Y4aq50GALeNzSkOS1U=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgIDqnvn_Eg&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgIDqnvn_Eg!2e10!4m2!3m1!1s0x47f29deecf2f8813:0x644b005eb1487c14"
        }
      ]
    },
    {
      "formattedAddress": "17 Rue de la Liberté, 21000 Dijon, France",
      "rating": 4.2,
      "userRatingCount": 2789,
      "displayName": {
        "text": "Burger King",
        "languageCode": "fr"
      },
      "reviews": [
        {
          "name": "places/ChIJc_wbNR6d8kcRT_uD0EgfFLg/reviews/ChdDSUhNMG9nS0VMUENzY2pvaVl1RDZBRRAB",
          "relativePublishTimeDescription": "8 months ago",
          "rating": 2,
          "text": {
            "text": "I was visiting the City as a Tourist and as a rest stop for the day as part of a long road trip, We hadn't eaten and ideally looked forward to some good local food but restaurants in France tend not to open or serve food  until 7pm, which was an absolute eternity when you're hungry at 4pm after driving 7 hours, so went to BK as a last resort. They only had about 10% of the menu available when I visited, only vegetarian options, which was disappointing and it may have been a pure anomaly or delayed delivery, but I can only base it on my experience.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "I was visiting the City as a Tourist and as a rest stop for the day as part of a long road trip, We hadn't eaten and ideally looked forward to some good local food but restaurants in France tend not to open or serve food  until 7pm, which was an absolute eternity when you're hungry at 4pm after driving 7 hours, so went to BK as a last resort. They only had about 10% of the menu available when I visited, only vegetarian options, which was disappointing and it may have been a pure anomaly or delayed delivery, but I can only base it on my experience.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Martin Sears (Heino)",
            "uri": "https://www.google.com/maps/contrib/106216209357951759562/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjW5pKsTJWWPPFocJlXWy6H-lIUubMmnTrQNmu7J9cjpy3qxfj5BvQ=s128-c0x00000000-cc-rp-mo-ba5"
          },
          "publishTime": "2025-05-16T04:39:03.095659Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChdDSUhNMG9nS0VMUENzY2pvaVl1RDZBRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChdDSUhNMG9nS0VMUENzY2pvaVl1RDZBRRAB!2m1!1s0x47f29d1e351bfc73:0xb8141f48d083fb4f",
          "visitDate": {
            "year": 2025,
            "month": 5
          }
        },
        {
          "name": "places/ChIJc_wbNR6d8kcRT_uD0EgfFLg/reviews/ChZDSUhNMG9nS0VJQ0FnSUNmakstYlNBEAE",
          "relativePublishTimeDescription": "a year ago",
          "rating": 5,
          "text": {
            "text": "Burger King in Dijon offers delicious food and excellent service. The burgers are fresh, flavorful, and served hot. The staff is friendly and attentive, ensuring a pleasant dining experience. Perfect spot for a quick and tasty meal. Highly recommended!",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Burger King in Dijon offers delicious food and excellent service. The burgers are fresh, flavorful, and served hot. The staff is friendly and attentive, ensuring a pleasant dining experience. Perfect spot for a quick and tasty meal. Highly recommended!",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Islam Kamal",
            "uri": "https://www.google.com/maps/contrib/110867307423734025952/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWCBaY5TSrdIgRLdCYk_ICewS1knwQy0Gce5WNhj9rJkvzG2y-8bQ=s128-c0x00000000-cc-rp-mo-ba6"
          },
          "publishTime": "2024-12-26T17:30:06.986110Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChZDSUhNMG9nS0VJQ0FnSUNmakstYlNBEAE&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChZDSUhNMG9nS0VJQ0FnSUNmakstYlNBEAE!2m1!1s0x47f29d1e351bfc73:0xb8141f48d083fb4f",
          "visitDate": {
            "year": 2024,
            "month": 12
          }
        },
        {
          "name": "places/ChIJc_wbNR6d8kcRT_uD0EgfFLg/reviews/Ci9DQUlRQUNvZENodHljRjlvT25aQlYyVlZOWFY0TTAxelYxTktZMFZETjJ0dVVsRRAB",
          "relativePublishTimeDescription": "3 months ago",
          "rating": 5,
          "text": {
            "text": "Great service, food is great and fast!",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Great service, food is great and fast!",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Theking Joaky",
            "uri": "https://www.google.com/maps/contrib/108392710507861228118/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUNKcFPQUsJ87skfJVXtthKBu3T6iRj0UooMNOIEwTQF6owGY6m=s128-c0x00000000-cc-rp-mo"
          },
          "publishTime": "2025-10-21T13:32:31.411458048Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT25aQlYyVlZOWFY0TTAxelYxTktZMFZETjJ0dVVsRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT25aQlYyVlZOWFY0TTAxelYxTktZMFZETjJ0dVVsRRAB!2m1!1s0x47f29d1e351bfc73:0xb8141f48d083fb4f",
          "visitDate": {
            "year": 2025,
            "month": 10
          }
        },
        {
          "name": "places/ChIJc_wbNR6d8kcRT_uD0EgfFLg/reviews/ChZDSUhNMG9nS0VJQ0FnSUNSOXZtRllBEAE",
          "relativePublishTimeDescription": "2 years ago",
          "rating": 3,
          "text": {
            "text": "The service is quick it really depends, sometimesit took awhile to serve, but surely the 5 euros deal is not bad. Tables and chairs are can be very dirty and not wiped after lunch. I don't mind coming back, better portions rather than McDonald's across.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "The service is quick it really depends, sometimesit took awhile to serve, but surely the 5 euros deal is not bad. Tables and chairs are can be very dirty and not wiped after lunch. I don't mind coming back, better portions rather than McDonald's across.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Calvin Locsin",
            "uri": "https://www.google.com/maps/contrib/111332789929958721821/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVs7xWzWJrmId2NWvP5rvDKU8B_RrIWryMipixXtBu5x9fsbmISTw=s128-c0x00000000-cc-rp-mo-ba4"
          },
          "publishTime": "2023-04-01T17:57:51.541451Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChZDSUhNMG9nS0VJQ0FnSUNSOXZtRllBEAE&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChZDSUhNMG9nS0VJQ0FnSUNSOXZtRllBEAE!2m1!1s0x47f29d1e351bfc73:0xb8141f48d083fb4f",
          "visitDate": {
            "year": 2023,
            "month": 4
          }
        },
        {
          "name": "places/ChIJc_wbNR6d8kcRT_uD0EgfFLg/reviews/ChZDSUhNMG9nS0VJQ0FnSUNyZ0xpNFBBEAE",
          "relativePublishTimeDescription": "a year ago",
          "rating": 4,
          "text": {
            "text": "The burger I ordered was cold",
            "languageCode": "en"
          },
          "originalText": {
            "text": "The burger I ordered was cold",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Oksana Sukhenko",
            "uri": "https://www.google.com/maps/contrib/100145995773024755240/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXJiisRV_VEI4QbT_BUFriWjZIzz7dW6ZvpOmuUpATarp9VzXdTaw=s128-c0x00000000-cc-rp-mo-ba7"
          },
          "publishTime": "2024-07-02T22:51:01.750526Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChZDSUhNMG9nS0VJQ0FnSUNyZ0xpNFBBEAE&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChZDSUhNMG9nS0VJQ0FnSUNyZ0xpNFBBEAE!2m1!1s0x47f29d1e351bfc73:0xb8141f48d083fb4f",
          "visitDate": {
            "year": 2024,
            "month": 7
          }
        }
      ],
      "photos": [
        {
          "name": "places/ChIJc_wbNR6d8kcRT_uD0EgfFLg/photos/AcnlKN3A4anDzOLrFz3t6fBev7UJXN2-c-6szRF_cXjQ0jpCwVA-rKBZmGWz4ddZ1BIhq12YtotyX__eYd3p5tp0G09BHGDHBYdjDUTIrQxmAXOTT6CU9vuFyM4Q6oPj6EbPHXRYngANaBv4CXvWluP7TT-Cz7Re8MMuCNVesJhE8Bk8Or5_EcQ-dOpH0o53AEeZffowlMyx0KS5rPRjlAGojbMCs46aN8rVE4PhrrWvXc5sBBP7Heyotaon2cVwvuJnCApKeNJ5ezBDdaM4RiHlQKfpm084mgLKO07mQFWtQNbV0g",
          "widthPx": 4032,
          "heightPx": 2131,
          "authorAttributions": [
            {
              "displayName": "Burger King",
              "uri": "https://maps.google.com/maps/contrib/103167315971447102619",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVym3N8eRHaDkuUrfqtkJFA1cArO4atxHp_H0hZ76cTt0qNJ-E=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipPg8JpdXP6KusvJTXaQdVFjYFUjM-6pcYJm-jEz&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipPg8JpdXP6KusvJTXaQdVFjYFUjM-6pcYJm-jEz!2e10!4m2!3m1!1s0x47f29d1e351bfc73:0xb8141f48d083fb4f"
        },
        {
          "name": "places/ChIJc_wbNR6d8kcRT_uD0EgfFLg/photos/AcnlKN1_hrAIsQBLjNZnXISbP8B_u0nyhfqOSA9R_CCFRxtTWGQQJPXcd9x_QH_v-mmbgEOekzAQETV-AtjPW2N3-hq1JQTYHJxDz3wquZy-83f316WxxDwIn9ROLzFgcfPt7-ygNM0WzeAmdDfH0P_0XS0pf2PLDt1ORjK03fC9sxyt5w6eF5UwKxydVTKY3fC314xIE3rUKg2V6cQcEwgc0kHHoRFUENhEn0bajBuf1WAMA7r3pRYe01U0vSDKB7BsL_SF5vqa5d9TbTfB1NInkbIZRwasx6laDrSOnvpd0cTZ2ViOjXdynskzPwmgu6RRIEm8O5PdrsOAIQ2XYrUkaAjQv0sftmEPVX0Ucz0gl4HY6cA2WkwUr64OdjFyhX-xjRDU6aB2jSRWQdRf4RB4Mx0UYcS2x5bXw9SPux_zrQv_jnU",
          "widthPx": 4000,
          "heightPx": 3000,
          "authorAttributions": [
            {
              "displayName": "Xavier Hamelin",
              "uri": "https://maps.google.com/maps/contrib/117643327575461583749",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVVrf1EHB0bWq3ypF3TL45R5GWhJG9R7XckLsVO8pZs_zZA5Ofb=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgIDx9KyVyQE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgIDx9KyVyQE!2e10!4m2!3m1!1s0x47f29d1e351bfc73:0xb8141f48d083fb4f"
        },
        {
          "name": "places/ChIJc_wbNR6d8kcRT_uD0EgfFLg/photos/AcnlKN26xxSntnFCd6OlCz4B321K5WfIhhY9oeTm0KJztXGwVw8ZVxBzFJpLf-RMNtXK6RIl0zUOrAtQSb59b5CbTc-9xI0nTMr7s6CBya3j2BK2zl6_zBjcHattUHi-BEMYujGJ5lS4zqYw8QTQEFQcK6_iUOus4GIQdy9l92QiSVjBqcDtHc0qO2qDfsqGfRFN_6O3aXLbAEtabZTPF_OFZhYHJVHk1vUzFiPJwheN9v5lG0lAgCaKbHN4lO5gojB6KefJG7aDc3WPUYnt0ml083CDhdC3iokd6ycYYEzBDMZZPXw-rSmdh7OZ9JJpNdG23VsFQEaPzcgn3Wp3oHqdKOJcrnVknqCcYpAi_eW1iKkkSPxT92zCnXpkLPBdkJIIzPwvuESwkZ9PhaJFnUZ3uew9x0iJs2cz7L4nvdfHyiVtqoU",
          "widthPx": 3060,
          "heightPx": 4080,
          "authorAttributions": [
            {
              "displayName": "Morgane FOURNIER",
              "uri": "https://maps.google.com/maps/contrib/104781809804630674207",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocLIt_2n6h3f2Pll4tayDKkR778ZDdN9bpBP4V8L69UrXNu1OQ=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgMCo0-_tjQE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgMCo0-_tjQE!2e10!4m2!3m1!1s0x47f29d1e351bfc73:0xb8141f48d083fb4f"
        },
        {
          "name": "places/ChIJc_wbNR6d8kcRT_uD0EgfFLg/photos/AcnlKN1udR3hQianP3uM3UXOCDJX8itZXhJF7RHzLbJlHWechfFF586B9K3TmFbjSWpU8nmB8MegpVDpV0hMNXC9G3LeBWuOidlBqN125ypk6attuN9YGae2K31wxmw_Xs0i8MnLWQZzS6PL3pBXtq1ga7_MDUydX-xLhD0RX-1tpqISNkHo-j_6i1dmuT5m_L38RI3s-9NHgo2wwexmhC-bUn0j8Bzhet8ztcBe7TRGNovo8xnjbkG6kaO4vsekcc_nSG4dv79E-1LeWmiTojqR_uNLnVzJ9s3T3xw_VXxaTf49O4ZsHV37idwkeYjAVMpGPFFcYVhy9_Xk3OHdRSRmd6V256wHxV9OtFu8w3RkWSbz_mW31LKNVrLfPQNecCGc9l_2QFUrfFu8aMVMsQGD8_jTQp6XYHagpmnE54vzjq6CILEG44rXmaNVTXe11KxK",
          "widthPx": 3000,
          "heightPx": 4000,
          "authorAttributions": [
            {
              "displayName": "Laura Blbt",
              "uri": "https://maps.google.com/maps/contrib/110205774163883496367",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVmHLRicMcNIFpKvRz9FFlEnfpZ5W-CfI0q5u0JqRd69nVSWO2T=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhAtQxQ-BjqQ5lTHPcaJb_wi&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhAtQxQ-BjqQ5lTHPcaJb_wi!2e10!4m2!3m1!1s0x47f29d1e351bfc73:0xb8141f48d083fb4f"
        },
        {
          "name": "places/ChIJc_wbNR6d8kcRT_uD0EgfFLg/photos/AcnlKN0IPYV5tPCOusPMRhTy5eGKVOl1aSPpnrwJfh-vHuw6acXBk1oXC1aj08aEddSrfBiScN_BS910dLMY-6hQfv0IbvbX9QkMm-s6yYbwN_LLgk9hhA2hcp9nBCVRWxT847fdWvbKSjSoGUGELiQzNHusbdkCskRivMG79KVrZ6RyEtFy6xQlrEIbOXYrtcDjOeJr4eOGVVueSHqclIkTYr9RCz4uRfvDLKY9REDXGdnwbWMKuZpOa-I5pRH4cQaZ8y9ttUxpdsNguoX547GdrPO35jJ64aW_1ChdFXV6ftdtKMYvJ9uh-ZPh4CeI6Rrr8MjSUxg_ZTrlfJ4ubqRzh7yhFYZtHrzA6AIKydUY3Xg-lxWJRtiqOr333w2S5NQKx0oY0IoWV5mHjg32l1xLnytfSBIf8_5fKFzWRrwm4WjhjljB4BTp-wOdnxoV_-1p",
          "widthPx": 4032,
          "heightPx": 3024,
          "authorAttributions": [
            {
              "displayName": "Louise Fournier",
              "uri": "https://maps.google.com/maps/contrib/109241445320973708999",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocIlSO8Q8RRZr31GJm0h_VRis0hD26G-yypS60phCQxe7epdcg=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhARxAoPlr9rt0Jtzrou4ZmJ&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhARxAoPlr9rt0Jtzrou4ZmJ!2e10!4m2!3m1!1s0x47f29d1e351bfc73:0xb8141f48d083fb4f"
        },
        {
          "name": "places/ChIJc_wbNR6d8kcRT_uD0EgfFLg/photos/AcnlKN2RotkHuUdvSKyqSMjKu_g2kS06tHFjhNA4dDCqSrxFHSD3HeYuP7dwAOlVadELEgPjROoltt7VcxQCtG0p0gxtpB76iPZdHUQ-YfpgEleR_DhCMKlMFxtU6uRJmpzJ5IL8Y1yrn_UIrPah4k07xec3IcsjrbTi_8vKH6TAD8YaxKm-mtqlHTdpjtBWf3hhSK_ZOk09zFwPyoJPeHkYos-4Q1eWQXs8EEV4KSC4g4004pqiXEn_89Jkh1ffFr_x0_gh1cbfBH5ZAOpAyQPnIevvV4PrVyIoc_mxTorUlvJdOXXjLRUFjrCfXXUz2-z13yDPm-e9-ruqVPkgzzhxnQHqZTpP-_ICDDKRkxJbH3jmXsligAmCapF1kkxyL_a_TiIwyIt1lA2CPp6OhytHEDhu2knNLzLoQx0wO7YDpoc",
          "widthPx": 3264,
          "heightPx": 2448,
          "authorAttributions": [
            {
              "displayName": "Islam Kamal",
              "uri": "https://maps.google.com/maps/contrib/110867307423734025952",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWCBaY5TSrdIgRLdCYk_ICewS1knwQy0Gce5WNhj9rJkvzG2y-8bQ=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgICfzPiefg&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgICfzPiefg!2e10!4m2!3m1!1s0x47f29d1e351bfc73:0xb8141f48d083fb4f"
        },
        {
          "name": "places/ChIJc_wbNR6d8kcRT_uD0EgfFLg/photos/AcnlKN1FLSZLtrKDSDgRdzFDM84JwjvK2AEqZlPPHWnLJ6yfxd-m8KzLVJ-0UHNchuUq6ebAmR7o-YYjY3K3zSoe4sbZCZ1TE2rD_2jw_Hfs0WiV0JkPyXd5NGPylJ3VA5qha6n7EFeVHYBygsNJBw9T20_oOaGBSUVxjH-n1Fn5zWaSvkmkZj5y7BjRregP_iq8k01KZ-R3JaDfjOGnJpdS10OSmkslmY7D1I2ZXrud4k4owElsteOUgNCUlsGHgWodg_KoM44uQhlUb0eLX2KZGJkZ5HRGHfTraEEYs1Tp0ZlDWPbGTasf-w6VpveIaCAMEO5LL2t_Gu3_uaFmoAlM5gCKb1MZLQPpeTihQsiXlj9IDeBIeVqmXrasWNYJtdVbz2ehPQRAUk0a8EX7DHN9t4JCvnugXtr4HQXuZnuzd8_cZheEmgFOL7fC6IrPZnng",
          "widthPx": 3024,
          "heightPx": 4032,
          "authorAttributions": [
            {
              "displayName": "Tetura Jiji",
              "uri": "https://maps.google.com/maps/contrib/114705996947821777379",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocLyLQk0xMBi9qwYzudJmHv8qkddWc61-05ljIIQj7PPxK55NA=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhCOMgzylmejg1GeMsNHb2e7&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhCOMgzylmejg1GeMsNHb2e7!2e10!4m2!3m1!1s0x47f29d1e351bfc73:0xb8141f48d083fb4f"
        },
        {
          "name": "places/ChIJc_wbNR6d8kcRT_uD0EgfFLg/photos/AcnlKN3V2KKsE48dDxc8SiZy-KrbDpkur6J3Odb0RABATv1iWlWHITe8Ooj8UBwIvCqrf-FJk80l7l6N1pTE9TkAxhStBaYSrVunLCIvDnHKJw3y3ap3fL95cRCl-cVUJ7tS7zF5iCgZpfXWDkSaQiLvRL6VTa1DxbvhF5IXcmzFhI-s8EckR6vmQv5CIFIFpNGWrUAG05K8oBoFccIYQ4fqNFq4-KKWUIsdueylC9pN9NwyWHo9Mmn7C_6_3QuIU4qkHHMSpsIPEnBfnfgvFrzU0rV590j37AI1IAr0rV1rCdEngfFjzomyzkp08eteFNnHnAgYvRlmjfiIKPkkSqM3ib1eqOQhB3hm2_26VSbshuOr9Cz2_xL8fyEnqLcyU98v-eaP94otI7j7flQJuse4NeVQESY20B90DTU6nAc2PphBSg8",
          "widthPx": 3120,
          "heightPx": 4160,
          "authorAttributions": [
            {
              "displayName": "lucien oser",
              "uri": "https://maps.google.com/maps/contrib/116478232020963773750",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVnKCOyTpM9huW0mClcgVwAbuTQzctduob5ZOiQKH95U7-mlCxj=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgICp8oyl8QE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgICp8oyl8QE!2e10!4m2!3m1!1s0x47f29d1e351bfc73:0xb8141f48d083fb4f"
        },
        {
          "name": "places/ChIJc_wbNR6d8kcRT_uD0EgfFLg/photos/AcnlKN0RwCiZ4QmACje3QAiEn8Gh5lPwrkKXuemdGObJ7Ixt4JkH1Y2eqPm2_rvGgq_0l9SQJZVV8OIWMXLrzCX2hxHjwq296qafjLgjbe1zEoR9v3x-6EeX86L5u_SkgxyQnDzcJLm_qfdZoZUnk7dxBPxrih1qsltHpdZtljW4S56ONmv45A1zFBZ6QxqMYycPbjagt708GqmQuZzRjcZDLFySl-n4BUpjzLnXLkRzCiIpIu0kzdzCwjZWCEQIRIGVs9RA5lZL9L95qEiM1yg-okJvTDy6QqXu_QNfIDbyz-pJRO2ki6-CitZ7a0qMtiE8MwaPOKQzbVI2EpkdD4TToeD6CBNXNZEQl2jNI0N--DMOyqwFyoVb1d77qdVE87BIUIo2sHuxCho5j4E6ZfUPQHCP3av5aDpbIQNFov3Xk9By8w",
          "widthPx": 3000,
          "heightPx": 4000,
          "authorAttributions": [
            {
              "displayName": "Xavier Hamelin",
              "uri": "https://maps.google.com/maps/contrib/117643327575461583749",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVVrf1EHB0bWq3ypF3TL45R5GWhJG9R7XckLsVO8pZs_zZA5Ofb=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgIDx9KyVSQ&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgIDx9KyVSQ!2e10!4m2!3m1!1s0x47f29d1e351bfc73:0xb8141f48d083fb4f"
        },
        {
          "name": "places/ChIJc_wbNR6d8kcRT_uD0EgfFLg/photos/AcnlKN3AEHUgX_TtRl60gI72YQMjo_jqq2hiunWKISoACzn-bVPbG6dp-1TbcvQlF-dm388R-iQ-5nk4rCa8FfRohLCBRQfglnKsn731HidT9gG6kqMzMCkXmoyoLwmKZOYZILUis_2UKfJqFMeyh-S-miFEKPj1jvnIb2W_uRmRS_s-kFBvz0YT49-YVOrsUnLW6PcSu2ELgdXfoHMnebglQatpPU9hIVE9LwVyK2YM7kC7avweFM99p-h3EHfRltEU2Wg2AuOmjsXMl5BfLHQ9n7DXETeG-1TUiMeutl3AwcJR0Q",
          "widthPx": 640,
          "heightPx": 480,
          "authorAttributions": [
            {
              "displayName": "Burger King",
              "uri": "https://maps.google.com/maps/contrib/103167315971447102619",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVym3N8eRHaDkuUrfqtkJFA1cArO4atxHp_H0hZ76cTt0qNJ-E=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipMCvmehXjramYULmcgsfdqSDq14RCznOWMn_-H6&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipMCvmehXjramYULmcgsfdqSDq14RCznOWMn_-H6!2e10!4m2!3m1!1s0x47f29d1e351bfc73:0xb8141f48d083fb4f"
        }
      ]
    },
    {
      "formattedAddress": "9 Place Notre Dame, 21000 Dijon, France",
      "rating": 4.1,
      "userRatingCount": 1638,
      "displayName": {
        "text": "Bouillon Notre Dame",
        "languageCode": "fr"
      },
      "reviews": [
        {
          "name": "places/ChIJhRozr5Cd8kcRzXWVpd5wDvU/reviews/Ci9DQUlRQUNvZENodHljRjlvT2pGVlltTm9TVzVxUmpWd2NUVkJaR0ZaTUdaM1drRRAB",
          "relativePublishTimeDescription": "5 months ago",
          "rating": 5,
          "text": {
            "text": "The best French restaurant if you’re looking for a quick and tasty option. Their menu is short but one of the best we tried in Dijon. Taste the snails and the slow cooked meat, totally worth it the wait. Dog friendly, reservations not allowed and you will have to wait for your table, but 💯 worth it.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "The best French restaurant if you’re looking for a quick and tasty option. Their menu is short but one of the best we tried in Dijon. Taste the snails and the slow cooked meat, totally worth it the wait. Dog friendly, reservations not allowed and you will have to wait for your table, but 💯 worth it.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Fabiola Perez",
            "uri": "https://www.google.com/maps/contrib/108328071450154191817/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocK6-Di-NiNseg78dIfc0Q_EMX0JGBTUfBIYvsh3L_HaRkbIFQ=s128-c0x00000000-cc-rp-mo-ba3"
          },
          "publishTime": "2025-08-19T16:02:18.062325488Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2pGVlltTm9TVzVxUmpWd2NUVkJaR0ZaTUdaM1drRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2pGVlltTm9TVzVxUmpWd2NUVkJaR0ZaTUdaM1drRRAB!2m1!1s0x47f29d90af331a85:0xf50e70dea59575cd",
          "visitDate": {
            "year": 2025,
            "month": 8
          }
        },
        {
          "name": "places/ChIJhRozr5Cd8kcRzXWVpd5wDvU/reviews/Ci9DQUlRQUNvZENodHljRjlvT2t3dFFpMUdPRnBLZVVac1MwaE1NWFEzYzFFNVdFRRAB",
          "relativePublishTimeDescription": "5 months ago",
          "rating": 5,
          "text": {
            "text": "I am glad to tell you about this magnificent spot in the heart of the city Dijon. Among the hundreds of restaurants and cafes we have found this pearl of the French cuisine. Though the menu is pretty short, you don’t need much to uncover the real story of taste. Simplicity in ingredients, simplicity in interior, simplicity in the good sense. This restaurant is everything you need in Dijon to discover this amazing city",
            "languageCode": "en"
          },
          "originalText": {
            "text": "I am glad to tell you about this magnificent spot in the heart of the city Dijon. Among the hundreds of restaurants and cafes we have found this pearl of the French cuisine. Though the menu is pretty short, you don’t need much to uncover the real story of taste. Simplicity in ingredients, simplicity in interior, simplicity in the good sense. This restaurant is everything you need in Dijon to discover this amazing city",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Sofiia Feklushyna",
            "uri": "https://www.google.com/maps/contrib/112654662325685646375/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVfzO4KCiPHNF52CKyc9j-8iwUfpS1QF4tmJa5yF7VX36CyFuw=s128-c0x00000000-cc-rp-mo-ba3"
          },
          "publishTime": "2025-08-11T20:17:00.476196355Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2t3dFFpMUdPRnBLZVVac1MwaE1NWFEzYzFFNVdFRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2t3dFFpMUdPRnBLZVVac1MwaE1NWFEzYzFFNVdFRRAB!2m1!1s0x47f29d90af331a85:0xf50e70dea59575cd",
          "visitDate": {
            "year": 2025,
            "month": 8
          }
        },
        {
          "name": "places/ChIJhRozr5Cd8kcRzXWVpd5wDvU/reviews/Ci9DQUlRQUNvZENodHljRjlvT2tsa05FcFBUMlZKTVhwMVowY3RkVGszVEZWdWEwRRAB",
          "relativePublishTimeDescription": "6 months ago",
          "rating": 3,
          "text": {
            "text": "A great spot if you're after a quick, tasty meal with a local French touch. The prices across the menu were very reasonable, and the food came out pretty quickly. The staff were friendly and efficient, keeping things moving without being overbearing.\n\nOne downside: they don’t take reservations, so we took a bit of a gamble walking there in the rain—thankfully, we got a table! It’s a fairly large place with plenty of seating, which helped.\n\nOverall, a solid choice for a casual bite and a drink when you’re in town.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "A great spot if you're after a quick, tasty meal with a local French touch. The prices across the menu were very reasonable, and the food came out pretty quickly. The staff were friendly and efficient, keeping things moving without being overbearing.\n\nOne downside: they don’t take reservations, so we took a bit of a gamble walking there in the rain—thankfully, we got a table! It’s a fairly large place with plenty of seating, which helped.\n\nOverall, a solid choice for a casual bite and a drink when you’re in town.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Menno Koedooder",
            "uri": "https://www.google.com/maps/contrib/101534189535974668223/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXOyHRtAG5qx0jQaHDScSrMZz5iu2MLLtxjxDpytj0R4eCvU1Qh_g=s128-c0x00000000-cc-rp-mo-ba3"
          },
          "publishTime": "2025-07-24T14:15:25.860327491Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2tsa05FcFBUMlZKTVhwMVowY3RkVGszVEZWdWEwRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2tsa05FcFBUMlZKTVhwMVowY3RkVGszVEZWdWEwRRAB!2m1!1s0x47f29d90af331a85:0xf50e70dea59575cd",
          "visitDate": {
            "year": 2025,
            "month": 7
          }
        },
        {
          "name": "places/ChIJhRozr5Cd8kcRzXWVpd5wDvU/reviews/Ci9DQUlRQUNvZENodHljRjlvT201SFUwcG9PVTg1WlhKalZUbDBUR1pWUlZGT2RWRRAB",
          "relativePublishTimeDescription": "4 months ago",
          "rating": 3,
          "text": {
            "text": "ordered the Dauphiné ravioli, but what I received was definitely not what was promised on the menu. Instead of authentic ravioli, they served cheap little square pasta with some processed cheese inside (the kind you can buy pre-packaged in a supermarket). It looked unappetizing and tasted disappointing. This was certainly not ravioli.\n\nThe snails, on the other hand, were good — that’s a positive point.\nThe restaurant interior was nice, but the service ruined the experience: our waiter was visibly irritated about working, and even told us he was “doing us a favor” because it was his dinner break (at 6 PM!). But another servant was good and nice\n\nOverall, the visit was a letdown: food below expectations, unpleasant service, only the snails and the décor made it bearable.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "ordered the Dauphiné ravioli, but what I received was definitely not what was promised on the menu. Instead of authentic ravioli, they served cheap little square pasta with some processed cheese inside (the kind you can buy pre-packaged in a supermarket). It looked unappetizing and tasted disappointing. This was certainly not ravioli.\n\nThe snails, on the other hand, were good — that’s a positive point.\nThe restaurant interior was nice, but the service ruined the experience: our waiter was visibly irritated about working, and even told us he was “doing us a favor” because it was his dinner break (at 6 PM!). But another servant was good and nice\n\nOverall, the visit was a letdown: food below expectations, unpleasant service, only the snails and the décor made it bearable.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Viktoriia Volynets",
            "uri": "https://www.google.com/maps/contrib/117654607768545270223/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocL8lcy8PhuIuAfJ-23kR6wIbXKY1yReCggXbxPv2nwXyOSYpQ=s128-c0x00000000-cc-rp-mo-ba2"
          },
          "publishTime": "2025-09-08T18:30:24.940096873Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT201SFUwcG9PVTg1WlhKalZUbDBUR1pWUlZGT2RWRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT201SFUwcG9PVTg1WlhKalZUbDBUR1pWUlZGT2RWRRAB!2m1!1s0x47f29d90af331a85:0xf50e70dea59575cd",
          "visitDate": {
            "year": 2025,
            "month": 9
          }
        },
        {
          "name": "places/ChIJhRozr5Cd8kcRzXWVpd5wDvU/reviews/Ci9DQUlRQUNvZENodHljRjlvT21aQ2FteDBkM28zZGtkalZuUnBWelZHYzJ4NWJGRRAB",
          "relativePublishTimeDescription": "5 months ago",
          "rating": 5,
          "text": {
            "text": "My wife and I ate a good boullion meal here in August 2025. We had seats outside, the weather was hot, and the to and fro of passers by maddbfor entertainment. We started with salads, my wife then had a steak followed by an apricot tart, I had bourguinon followed by cheese. Service was reasonable prompt.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "My wife and I ate a good boullion meal here in August 2025. We had seats outside, the weather was hot, and the to and fro of passers by maddbfor entertainment. We started with salads, my wife then had a steak followed by an apricot tart, I had bourguinon followed by cheese. Service was reasonable prompt.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Paul Burrows",
            "uri": "https://www.google.com/maps/contrib/115943356553276652750/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocL7CfjUjG9uTlvmr3u9hVz6lrFM1njoRVmDuVXt1nMa4ABfLg=s128-c0x00000000-cc-rp-mo-ba3"
          },
          "publishTime": "2025-08-09T07:34:44.778430911Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT21aQ2FteDBkM28zZGtkalZuUnBWelZHYzJ4NWJGRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT21aQ2FteDBkM28zZGtkalZuUnBWelZHYzJ4NWJGRRAB!2m1!1s0x47f29d90af331a85:0xf50e70dea59575cd",
          "visitDate": {
            "year": 2025,
            "month": 8
          }
        }
      ],
      "photos": [
        {
          "name": "places/ChIJhRozr5Cd8kcRzXWVpd5wDvU/photos/AcnlKN0L2W_XFnum0Iuj218HS1g7SK_PaVC-ViCpNNIFVD4Q1NTHa7u2LX7wE2ITC-XbYLGomrpNmxNMEs5gj9oh9icGWVFW46ug3BqiXnzezRSd7XNb9XYYGRWRBctcMfxAmpB9K7GuOAqG9hvOMI5jaIzSjLURRSzRSNJonfCpJs-QADHcCMjMah8NyNMBj7TxcosgW2GcG49ujVGWOy1AlEfnxPaHF7T4dofPIU-cFANAzlq4-v7a7Xwt3zhvLHD7tP8-XnQNS7O0_R-ZZhIeW7v0vpDZiu8tOlo3ljmoTuExgYUzc_d1UG8oJ7VPImekj5ZVHW-T1p_v8we_84-HBgdfFdglFmnmv4v9JuqlQZaJOCXnQgIUmgUuLlDtj9ZQ4X52HkhnIXYgEYKIq7jhl3SoDHwuvjJOBr8u_wqUoRk8hfoI",
          "widthPx": 1600,
          "heightPx": 1198,
          "authorAttributions": [
            {
              "displayName": "Marcel Patulacci",
              "uri": "https://maps.google.com/maps/contrib/110324028115675240735",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUZZ3P_j6bL_4SeImFu3ouzkJnZcmodChEXzgUjl9Job3HJidE=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgMCwqbTvswE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgMCwqbTvswE!2e10!4m2!3m1!1s0x47f29d90af331a85:0xf50e70dea59575cd"
        },
        {
          "name": "places/ChIJhRozr5Cd8kcRzXWVpd5wDvU/photos/AcnlKN3lG64xhqmL_xNbKKLdQP-jS_5L0UNQkPbQQHHoUAy90AYAj1oUZLj3DDd8BvXE-PoA1G1K-63agmc4OvN7UuiSeTuWphPHvK9oxbUa3eQd6jef8A6JzEZc0JbGD5qpfxdBUqzAiZCIizqxBcNpULn9RTOLp-ulVsCNWce9n8EzyFg2q5GT_UWV2C_C5l88SFkZbbdlo1uUG2E3kX4Ive4-8jjiUlSnYCKdobw9cMwkcpZXraSgFEzPJFFSujj9mnEXdvzJTlzow5H7ia3f3smQWfnFN9XfAy_KD01vkiYFI-EYFD1JuwmTRnd_B1BA4T_l9QUaGytcdERm29pFUkbjoJg1NM-LhME8XyqkIqLjXFqsYBL2oC_jG3UCbvfi4uAYDps2AEZTFHd8T2HmKmwBL5lPH3Ay_LZjQ-J6W1-FGD82a481CV7JNaKU4um9",
          "widthPx": 3072,
          "heightPx": 4096,
          "authorAttributions": [
            {
              "displayName": "Anaïs Brunel",
              "uri": "https://maps.google.com/maps/contrib/111749636320467984662",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXaC_TX_CHFQbt8PXSQw9FRzeRiEMY-r-Qf7CvQH11IThDSTzlz=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhD0pLOoSdc6aIKM4z-FM0Xu&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhD0pLOoSdc6aIKM4z-FM0Xu!2e10!4m2!3m1!1s0x47f29d90af331a85:0xf50e70dea59575cd"
        },
        {
          "name": "places/ChIJhRozr5Cd8kcRzXWVpd5wDvU/photos/AcnlKN2hiKfW0-cdRlN6X3Wn4OJmF55_RZFFy6JHNliFLq8Vwhs39sb9Qs4T-UMQ0ioEFlLYexpAv_PaCL_R-BFxx98d755YHWhcKQsMFNIRcagUbXLi_ayK_jsJMiuoSUXoYIL8unJpu29lo7VQRGfw6Ladkots35pMRoBD6eSYOmEwkJ9P7uaNQAV6cA1UPu5r4U8BGdkg1-7U28LfBK9nJuT2FqpM9ki3svOavRciuwZlqYN7cq6YhpV45Tg1o5mio7Vp4_9QA1LGaZw-c86om8l62hersfPmUxGaAWEC3Uk",
          "widthPx": 2048,
          "heightPx": 1365,
          "authorAttributions": [
            {
              "displayName": "Bouillon Notre Dame",
              "uri": "https://maps.google.com/maps/contrib/101197510813307308793",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocLlcHbUvelQqDwFvCe1nOEOUEHfgg7GpsVpEE3O6J3XPBwP=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipM9lwwexIjSyWEKIEObSQKrETh0trfS7Ch20jI&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipM9lwwexIjSyWEKIEObSQKrETh0trfS7Ch20jI!2e10!4m2!3m1!1s0x47f29d90af331a85:0xf50e70dea59575cd"
        },
        {
          "name": "places/ChIJhRozr5Cd8kcRzXWVpd5wDvU/photos/AcnlKN1KCuy1j1eZf02385DjizHbdNX3zdyxDsaCF8D0ZZgI3Dtq2ELXSmTKJwOyy8qyeAuZeg-ADqn2eW4vSGraJMgtQZa9xmlWUraQ_bT7oX1ekxCUMvfSQ8viJ95HRa6XvYTjCD5c0tPJENfd4evC23JhIiS_ILYVPPNyPMhOn-on4M12I2tAsElUGr9BtzlT4-fDlVImorKKG1fPS-Z_BCwOPLECjbdACdLIMBIQJ9wi3i8rcUK_b9SZmYGZZ8WInKVFev6W83yTxvrAxsYi2CB28pCbfKbX0rXTAKdWdrZkrGZVjokBfkHK33RJC_WbMD7Jq0x4jxrAv8OIRdnb7WqRdOwB3xhtx2glsVqMY3toF_IyRKkaWWfDtTcLy5XCarQMZTaZA-Z043eR4OqNO7Bd4FRbluvaNzbr-Mr_Ibg_46n3qQsODtI0Txq9BA",
          "widthPx": 3468,
          "heightPx": 4624,
          "authorAttributions": [
            {
              "displayName": "Paul Burrows",
              "uri": "https://maps.google.com/maps/contrib/115943356553276652750",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocL7CfjUjG9uTlvmr3u9hVz6lrFM1njoRVmDuVXt1nMa4ABfLg=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhCXvtPX8V9mgIA_Au3IYCIW&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhCXvtPX8V9mgIA_Au3IYCIW!2e10!4m2!3m1!1s0x47f29d90af331a85:0xf50e70dea59575cd"
        },
        {
          "name": "places/ChIJhRozr5Cd8kcRzXWVpd5wDvU/photos/AcnlKN01dXtwLYBdFJcVdeaL4EXP0pL7mtPzpjxMEr_3pzt2AVyCsUxLPu041GqoQw3J6nHNin0hnHyc5oQoGGtVZhtwdn0Uk18UynlhDQfl08Qh_Db3VMlyrnB9uCtMMa7fQQoMt0VG3_yRrbwfliNTXNSAi13P-n4KpfwLiv03GESwybn22_n8VbcHDUPRA3c1ZTIfU-uLxb7BEOBjf283zg5xkh-BFlduwYQhUZDyd5tP5Sl4EC4D9p00r-fc4z-8WjW1v88bzZF2Ddp77Ev48wltq-325vpMOmH2N0584zmYkN9uRdPVWRnFlI3_1ygBkLxAZ8UPqVRc6i4LO8a2nnCCXpqqTDHWCB_m71N_Nxf5ljTMg2aJ1kRuJkKU4TAG1-cQZBONpBvi7NcOmNBzMtRhnZw_JLJmbLy1shwjKPM1tmiovcjCM7eA1liTEw",
          "widthPx": 3024,
          "heightPx": 4032,
          "authorAttributions": [
            {
              "displayName": "sergio",
              "uri": "https://maps.google.com/maps/contrib/116348114787039554245",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUhFqEX0Uvyi7-9kIRim0UiTfY5Lld_6GsiQsYW4GJOG-3sVIOH=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhAF-3lrQ-m-tHlcCNH1EcZ9&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhAF-3lrQ-m-tHlcCNH1EcZ9!2e10!4m2!3m1!1s0x47f29d90af331a85:0xf50e70dea59575cd"
        },
        {
          "name": "places/ChIJhRozr5Cd8kcRzXWVpd5wDvU/photos/AcnlKN35mXa4KS_6MPT-oeh5Z-SJUHmkWpAbmrdNhIfsVe6r-hJxmY_Cj7StEV86c6lFqMfxuNDQKXoBgX8cqd7aGzRSeWlNTToO4AXCtciC6lWb5Tlxe7vQRxresLK8IWJUk42DnXnwCyg7deqgFeeD56-ezUZHstW-wGBEuZjIANDtEq5FDB8dS4PjPrFFS57Tvs0qOHspkB4yLvkrz3Yws8OKaffJxPDcAuLgvetBAP1GvZcMYK_FIH1cKLJ1eLSbMP-GmOWUHyqnhuFErmn0dHVaUNBK_lTwX5Igjo_8zS5wQ-fIpAYIfASml8sJ5aTtxzhq-FCTYXNintLDvRLc_3eJnIkHcbFsXFF1zEdQC7IGs-XmGv3I5CSZ9oaKvoPKajwlXqUtNQBqZp_VIVcwmsu8JioENlJ2cNPFm4f_3t62eoPY",
          "widthPx": 3652,
          "heightPx": 2649,
          "authorAttributions": [
            {
              "displayName": "Markus Hehner",
              "uri": "https://maps.google.com/maps/contrib/111114934809428659052",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXKN7f5rF3bcnMlKmhN7PxM-vMFIadEl7aq0KgV_LzcXLvAeYAx=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEPithqmlv7bR0wE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEPithqmlv7bR0wE!2e10!4m2!3m1!1s0x47f29d90af331a85:0xf50e70dea59575cd"
        },
        {
          "name": "places/ChIJhRozr5Cd8kcRzXWVpd5wDvU/photos/AcnlKN1wWlso0JhBkqtTdhzLrQnWQVhALii9E72BoZtzx4InrDvAiVkOrlY4QiaP9hmiwoS6bpiiJwmynBOtS_xVrFkLg21y0Bn_BnK7E6HdM59BiJHf8KENWNm8Pf_cGopKAIc2BJg_igMFxIsOf51V96Y5AoBqFGAvBda8SayJEVX-C7nt1oz59DNRgkto9ZBU0eE0G8QpW7_Mq2gvI4zAMCpgF6yyKzcYpRe_g1wihlES02IjwPTxkhx2o3xwAlf-2T5-26mhccSZxm-oRckAjVXpNge2Czno-u-5F7QmCK3fWfivN4xvee0YkplbSikvQ6V8_iqE1yROe5F79C8aKxuyDDHC0LYfqAbxag7v-I3NhcEcfYZfSO-e3tK1jWWDFMsyZpIPJjo9AWc1tO97i2XOr64jE-2tx67SxyZ1X_pkts08vNIKZyBwwN9PWpWl",
          "widthPx": 3862,
          "heightPx": 2616,
          "authorAttributions": [
            {
              "displayName": "Nathalie Misset",
              "uri": "https://maps.google.com/maps/contrib/111034195568521944063",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWVkrda2Hfo6e_gfOEh7udX2ti-Si7bddHh4yjz7p7GaW0FT4irSA=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhCBYfRZ1qFKoCOGkpnKSx-0&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhCBYfRZ1qFKoCOGkpnKSx-0!2e10!4m2!3m1!1s0x47f29d90af331a85:0xf50e70dea59575cd"
        },
        {
          "name": "places/ChIJhRozr5Cd8kcRzXWVpd5wDvU/photos/AcnlKN1hs0q_Wz27Y7jwjwhIYGwqwlNbg7ir31rzrFxa7dTiR5eCUhpgKHJ_20bVfVXWleQC-Va2e4_XH1Cf3zMl9BRzKhGkdi6Kw6d-PW8jil4z8LVfjePRiNo6vMIn9q2T_7PT0LY3kyTCBb39g4MgdIZuTBDqDbXtby6BmJu91per6kipKhQ7JhV3jnT3plVxzxl95NIzYPaUXpJgmeSG1jYr5uOgy5K5gQZ3q3zkS7kr7qOpPtxi75n1HTLlImySjMOi_FkSUScZy2Yrxh00tgts_jol5A5n9yrpV1TleQst7dWFzn9QNv2VtwUW10Vld_BGikUSyNGZcgzOibhdAwXHxOUb8jcb0-O-NLThATBRrQu7wAD26pfnI_GLgqSlsPMTQOXBBz2QQd9iu-H0MRSKkQ0dEbjpFCOh7QLtw7U",
          "widthPx": 1490,
          "heightPx": 1125,
          "authorAttributions": [
            {
              "displayName": "Tatiana Egorova",
              "uri": "https://maps.google.com/maps/contrib/100092611294354744644",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVBWpxAZpKQKnREQ8bv8EFFuEQtWjMNZT6hhVw0elZO1dajF6TgoA=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgMCg6N-dLA&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgMCg6N-dLA!2e10!4m2!3m1!1s0x47f29d90af331a85:0xf50e70dea59575cd"
        },
        {
          "name": "places/ChIJhRozr5Cd8kcRzXWVpd5wDvU/photos/AcnlKN2ISuWWALl5AvDpnG_9in2iqGkSsBFz_shGXKlsP7n8rwC9qAZRaCqFG6N7C6kyc83tR2DkppaONEHmZ4LIbgBNsSbrkm-BD4OzKf4aqERN-RR06-zsf0b-E093zD2ONAE0gepYw3hWdPWW-maArg2Jr20G7IZl4c31IlKEY2IdNR-hir3CXBEnZYTobuaK48YI3rEsHiMOeSYpCRNhott7i08eK8L1GKZ7jxnC2sBQ_RNyLxLOd41laLOUf46vkJp3vBMDfyjDhh_6m-4isVavrR_T57g9QFCTqVWFhFpPlAxEU75G9BvqSBKe23p26fn-ZK6j_GYqCyFZQxQZ4djvzMKyP278uxai5z858NFcSU9ww5nEf8UNKw3Uu8ORvrGCCtqW1O1WjpS_YVqiI0K1cCJx7dd0noXPxdFaez9dnKox",
          "widthPx": 4000,
          "heightPx": 3000,
          "authorAttributions": [
            {
              "displayName": "Partha Roy",
              "uri": "https://maps.google.com/maps/contrib/117997791116709282388",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXboGhwJrGAsHFakv8EhPVRUhYFzdfrnVbM-aHMPZeX7bvUtbVb=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEN70v_KIudjhmAE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEN70v_KIudjhmAE!2e10!4m2!3m1!1s0x47f29d90af331a85:0xf50e70dea59575cd"
        },
        {
          "name": "places/ChIJhRozr5Cd8kcRzXWVpd5wDvU/photos/AcnlKN24FTHf2AY1GCiq60jtdIYuNd0tAaGSVVv9Qq5PHOa4KyUNSacKHdKFUzjPSv4YWKEiAx0TCQCvV3MdWzp-ZGKSC4VgiY5LW3zVv4LlAEtJh0740V5TdXW_VvtSe_kXqgfU3iUe4aSF-ltDHntHQvdkQZmI7RNEB7mg5FyQApHG5o4aKNiedR4fOpLChDg0UdFZHcmwFoBIavXzcFbAQlX55nYb0ZrbheJp_j-mJXxhAdJ9T5XLX8BWU4PLrsLWqjW8SVo7qwYyCSVhVqMZMEXVHs8ETgHkvoFizNpR0jLdKvNN5-grHQKAsIjHOULnPq7JMJXf-v-pbcTNLstNQlYuouXUY-JucecnMQSTAk-gtgxNpa2DWO5uuF8g3LjljpG922dqD24QudMNq5hRMeJSRkUOxTsYFcue91M8vxNjA6PUz4OsBf-mCAOJpc4P",
          "widthPx": 2895,
          "heightPx": 3860,
          "authorAttributions": [
            {
              "displayName": "Sonja F.",
              "uri": "https://maps.google.com/maps/contrib/118072880109288140745",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocJe9juMBT7Lj77V0cQbFLVHJAs-yRjqDZBIM7K23kGYjdzPAg=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhBNdesOEoZqPt8ht3cihrwA&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhBNdesOEoZqPt8ht3cihrwA!2e10!4m2!3m1!1s0x47f29d90af331a85:0xf50e70dea59575cd"
        }
      ]
    },
    {
      "formattedAddress": "36-38 Rue de la Liberté, 21000 Dijon, France",
      "rating": 3.2,
      "userRatingCount": 2572,
      "displayName": {
        "text": "McDonald's",
        "languageCode": "fr"
      },
      "reviews": [
        {
          "name": "places/ChIJLdu_wOud8kcRGpcl8kQoiFw/reviews/Ci9DQUlRQUNvZENodHljRjlvT2tSbFMwVXdZVlUwVkVkb1MxTTNia1pwV2taMVVtYxAB",
          "relativePublishTimeDescription": "3 months ago",
          "rating": 1,
          "text": {
            "text": "Terrible.. the manager with grey shirt chew gum. Others playing football with a paper bags.. we have to wait ages whilst they are playing around.  Good waiting in the area inside getting cold whilst they are waiting to complete the orders.. very poorly run establishment..  I've never seen this before in a McDonald's.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Terrible.. the manager with grey shirt chew gum. Others playing football with a paper bags.. we have to wait ages whilst they are playing around.  Good waiting in the area inside getting cold whilst they are waiting to complete the orders.. very poorly run establishment..  I've never seen this before in a McDonald's.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Peter Seitz",
            "uri": "https://www.google.com/maps/contrib/108659837506848324436/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocJgBFy6KzK5D6Z5qUgI1ngIcZv5P2G6Uq0znYUrCwLqa4eqtg=s128-c0x00000000-cc-rp-mo"
          },
          "publishTime": "2025-10-24T15:56:45.720082117Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2tSbFMwVXdZVlUwVkVkb1MxTTNia1pwV2taMVVtYxAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2tSbFMwVXdZVlUwVkVkb1MxTTNia1pwV2taMVVtYxAB!2m1!1s0x47f29debc0bfdb2d:0x5c882844f225971a",
          "visitDate": {
            "year": 2025,
            "month": 10
          }
        },
        {
          "name": "places/ChIJLdu_wOud8kcRGpcl8kQoiFw/reviews/Ci9DQUlRQUNvZENodHljRjlvT20xZmIxQnJNR3BaU0dOSGJGQmZhR3hoV2t0TFVYYxAB",
          "relativePublishTimeDescription": "6 months ago",
          "rating": 5,
          "text": {
            "text": "I had a croissant 🥐, but it was cold .\nThe staff was mad because I had a Barcelona t-shirt. But overall it is good, but you can't order any fast foods like burgers and fries till 10:30 before that you can get the breakfast options like croissants and coffee and macarons.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "I had a croissant 🥐, but it was cold .\nThe staff was mad because I had a Barcelona t-shirt. But overall it is good, but you can't order any fast foods like burgers and fries till 10:30 before that you can get the breakfast options like croissants and coffee and macarons.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "gustavs ozolins",
            "uri": "https://www.google.com/maps/contrib/117972269992637669712/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocI6ft1vQcP9L7lCByrcf_FaAszrRr4nmWRT_Ilkou8dU7cfgg=s128-c0x00000000-cc-rp-mo"
          },
          "publishTime": "2025-07-20T08:06:25.377921931Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT20xZmIxQnJNR3BaU0dOSGJGQmZhR3hoV2t0TFVYYxAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT20xZmIxQnJNR3BaU0dOSGJGQmZhR3hoV2t0TFVYYxAB!2m1!1s0x47f29debc0bfdb2d:0x5c882844f225971a",
          "visitDate": {
            "year": 2025,
            "month": 7
          }
        },
        {
          "name": "places/ChIJLdu_wOud8kcRGpcl8kQoiFw/reviews/ChZDSUhNMG9nS0VJQ0FnTURnX0k3eEZnEAE",
          "relativePublishTimeDescription": "11 months ago",
          "rating": 1,
          "text": {
            "text": "Worst McDonald in what I was! Empty restaurant. No operation and I waited for McDonald 25 minutes. Shame and I don't recommend. Cold big mac burned fries.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Worst McDonald in what I was! Empty restaurant. No operation and I waited for McDonald 25 minutes. Shame and I don't recommend. Cold big mac burned fries.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Marian Bajzik",
            "uri": "https://www.google.com/maps/contrib/101328234593265486348/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUfc2l2igEz4XGESLhPfd-6lEz7z2Q-bGUeJQCXHAbP2Lg_RF53=s128-c0x00000000-cc-rp-mo-ba4"
          },
          "publishTime": "2025-02-23T10:36:06.695952Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChZDSUhNMG9nS0VJQ0FnTURnX0k3eEZnEAE&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChZDSUhNMG9nS0VJQ0FnTURnX0k3eEZnEAE!2m1!1s0x47f29debc0bfdb2d:0x5c882844f225971a",
          "visitDate": {
            "year": 2025,
            "month": 2
          }
        },
        {
          "name": "places/ChIJLdu_wOud8kcRGpcl8kQoiFw/reviews/ChZDSUhNMG9nS0VJQ0FnSURNd2RuN1hBEAE",
          "relativePublishTimeDescription": "6 years ago",
          "rating": 1,
          "text": {
            "text": "Honestly I have had McDonald's in France before and it has always been a shock for me as the quality has always been good. My experience was far from that mark and quite frankly dissapoting.\n\nPost New Years there isn't much open and as a tourist went to my last resort, and even ordered one of the \"specialities\" which was dry and tasteless, with French fries that were soggy from oil and slightly old. I'm not asking for much but this was a let down over my past experiences.\n\nNot to mention the service which was good but as you can see from the photo the tray was filthy and black with dirt on a white tray.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Honestly I have had McDonald's in France before and it has always been a shock for me as the quality has always been good. My experience was far from that mark and quite frankly dissapoting.\n\nPost New Years there isn't much open and as a tourist went to my last resort, and even ordered one of the \"specialities\" which was dry and tasteless, with French fries that were soggy from oil and slightly old. I'm not asking for much but this was a let down over my past experiences.\n\nNot to mention the service which was good but as you can see from the photo the tray was filthy and black with dirt on a white tray.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Seán Callum",
            "uri": "https://www.google.com/maps/contrib/113816714971359082750/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXXCr94N1sYin79YZdi6VLVB0D0FeqeCHx6mt8UbmEVvlFR_dZscQ=s128-c0x00000000-cc-rp-mo-ba7"
          },
          "publishTime": "2020-01-01T16:49:29.931198Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChZDSUhNMG9nS0VJQ0FnSURNd2RuN1hBEAE&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChZDSUhNMG9nS0VJQ0FnSURNd2RuN1hBEAE!2m1!1s0x47f29debc0bfdb2d:0x5c882844f225971a",
          "visitDate": {
            "year": 2020,
            "month": 1
          }
        },
        {
          "name": "places/ChIJLdu_wOud8kcRGpcl8kQoiFw/reviews/ChdDSUhNMG9nS0VJQ0FnSUR1aTdLMmpnRRAB",
          "relativePublishTimeDescription": "3 years ago",
          "rating": 1,
          "text": {
            "text": "Extremely dry burger, like if it was cooked yesterday. Barely no ketchup and 1 pickle!! €3 for a s**t burger. Definitely the worst McDonalds I’ve been in my life.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Extremely dry burger, like if it was cooked yesterday. Barely no ketchup and 1 pickle!! €3 for a s**t burger. Definitely the worst McDonalds I’ve been in my life.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Pali G",
            "uri": "https://www.google.com/maps/contrib/117641511697586074095/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXJQcLe4CH9qKzdNQVKyh4MdL0ZO1_741bEneJD_LEnIsogZxD76Q=s128-c0x00000000-cc-rp-mo-ba5"
          },
          "publishTime": "2022-08-29T12:21:00.912957Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChdDSUhNMG9nS0VJQ0FnSUR1aTdLMmpnRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChdDSUhNMG9nS0VJQ0FnSUR1aTdLMmpnRRAB!2m1!1s0x47f29debc0bfdb2d:0x5c882844f225971a",
          "visitDate": {
            "year": 2022,
            "month": 8
          }
        }
      ],
      "photos": [
        {
          "name": "places/ChIJLdu_wOud8kcRGpcl8kQoiFw/photos/AcnlKN183Jb_Pdc6zmcwywBWCukTnDraN5x02S6jRZspcebKl7Y-9SS3hrkrsFzwOmhSejBmf-Bhtot27UGSZcZY64--NqTTLIVdAzo7VohMtnOQs96e4rvJavAiJ6C2CrJkQ-WFZ4_7CwHWRe8m9w08nElNak0ec0Gu-_F3AJgnVfNA2zr3JYI2r1-uM4UOxsxarXF_93I1ZK6O7zmqzGg18ZVdg-u6INOsJSXH95myG5DCNZOuKozjO8aW8G6Jg7RY2f37fGLDcMZLPLYkY4DU9rrUEsUFnFf9QyCuXcyYVVGtW_nStNXgwTzILTY4srudXwCYgN4eRX9Imc9AR1fcja2ZQCW1jNFbSj2w0eaVffe2z7GAj-ivWK-xfJSJQvIB9nmh28ItNYou4DNJmOeZL5sxMOFWcHVxlTS-vdoVKvhzcw",
          "widthPx": 4080,
          "heightPx": 3060,
          "authorAttributions": [
            {
              "displayName": "Seimen Burum",
              "uri": "https://maps.google.com/maps/contrib/117451913948902098328",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVVCgsTXZjK9Y5q1JgJpy2PUq6nBFBsGHJcUn9pRlATuiDjPcc=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgIDp75KZOg&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgIDp75KZOg!2e10!4m2!3m1!1s0x47f29debc0bfdb2d:0x5c882844f225971a"
        },
        {
          "name": "places/ChIJLdu_wOud8kcRGpcl8kQoiFw/photos/AcnlKN2SMu8wkYDbjc3cdn3cF2KYNv7FYsIZpa_WeZ1cLVJnNfbqvwn9EK-hDxsLGG0XmBnhpGGB4CmeGCTON1HJeLC3yFMWZoxqUvW4IkY4PQGjntRwqGhfEeWN2ne0RVZ9jx9Uy7-VibpVu6v-m-FUbe9dlbbVMS22lM2D2lDpSbry5H-Oa-CWGC9W4eClJ7jIrgTqIAJ4b4zy53DqYhB8nOPrMIx31sa2kNuOKOoH8n0zG-Iae3MzDYWUbFcKfpyyWr05xH5W7GOorpW-VkBo7QNv8kDntpJ9P5Pzt4mf5wAcWQ",
          "widthPx": 400,
          "heightPx": 400,
          "authorAttributions": [
            {
              "displayName": "McDonald's",
              "uri": "https://maps.google.com/maps/contrib/109339373968251462616",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWb2zLZfn_pThJRkaXxI3luN2Jjp5RoqkEWJKvLkc0_KEjsdn8=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipOM_YM3s8e3W-MJ725taug2YV1HPC8jQ4Nu9WxW&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipOM_YM3s8e3W-MJ725taug2YV1HPC8jQ4Nu9WxW!2e10!4m2!3m1!1s0x47f29debc0bfdb2d:0x5c882844f225971a"
        },
        {
          "name": "places/ChIJLdu_wOud8kcRGpcl8kQoiFw/photos/AcnlKN3ERyqpodWcASqlr05XWDbnDAqyTD2f_D9yPwB5tyyMMLYNEm-MDgrgxeB5ocW7_a7FA4hRll56PqsgpDRRvEQpEG9NSE6j_3GEsUQi-HyFYz4pK-7bG1QtEqGenc4-PGav7cSubkSltzjM8JugBns-KkPlYntgPpDv3-Tq637tZgt2_XFX3OJfWrKx0UJdJeL39HMKBRGrevxyHyIkIOX39h2vjspo-d5RLhfMXAAskMBaTUXNvyiLh3TWuMdeKVYTCYTIYXvyOGMSPr1T8uJE27mrcqL8eXtSUDhLQ1vz0L0NTHXouUviubMTlRx_MNwxxmjs-6xaCWDGGxJsRQjKXEtHjPKtMxwdMfeOCu3eLzZh3XLGKWm-EPmYkn7W47HGVa7FP64o3XReTGAPSqzuKuAxi2ayen0h3NXYuwmXFw",
          "widthPx": 3264,
          "heightPx": 2448,
          "authorAttributions": [
            {
              "displayName": "Islam Kamal",
              "uri": "https://maps.google.com/maps/contrib/110867307423734025952",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWCBaY5TSrdIgRLdCYk_ICewS1knwQy0Gce5WNhj9rJkvzG2y-8bQ=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgICfzPjEeA&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgICfzPjEeA!2e10!4m2!3m1!1s0x47f29debc0bfdb2d:0x5c882844f225971a"
        },
        {
          "name": "places/ChIJLdu_wOud8kcRGpcl8kQoiFw/photos/AcnlKN2iiiFxBNTVC_ugwiYkG84S9Azt-FHW9a_w_jk5dwF1qCsoz_6YxTffbRzcpR-7Fxaa6dWqVMGr4Nj91bIs82i23cYZNJgHFM5onPp3mtRf3eACOwcNImSbdVVUECk-3otQHOu2o5vU61bNyL0b6yjQ-3N-NpYNWKkHhqCSwaeZTPDpvRHGdTPvlT_56bCufVjJQ5whvwLx-TbHOgZreKRJDeCvoG3aYk9DfAxY34AW64VJOiuBuiOovBsSYDqJA7AhQ8e77yetXTm64VY6-rKfs6xxmdulR3ZEc32iLrZvC-1Tn0F--qycDItIdR65CTp6kDbEygyxw1hLUIaJfymQyXFIQIUiZM_mYwVDlccphYWHx1BVSLPT9_2UPqU8K_o4mhzAgrNPAVq9P6SaEqkEijfMssQx0H59txvFhuQ",
          "widthPx": 3024,
          "heightPx": 4032,
          "authorAttributions": [
            {
              "displayName": "Magalie Duchesne",
              "uri": "https://maps.google.com/maps/contrib/109374246510140771517",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocKCCsahN81VMEPoCq95ewpfDqQTWElCS973a_J7PLyheJKweg=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgIDnvPHAcQ&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgIDnvPHAcQ!2e10!4m2!3m1!1s0x47f29debc0bfdb2d:0x5c882844f225971a"
        },
        {
          "name": "places/ChIJLdu_wOud8kcRGpcl8kQoiFw/photos/AcnlKN2_LgGvggcNuiGQqvM7_SY7cNdAUTxe5MPG4UwsptDj5cXW3-rJGo4OsS-bFpG9bf_ET0qIBE0IV80T_SXPE7T2QrZXTQPNgECort-Lh3TmI4XEYM6sTC2oGhqswq2uNUTEr-7AYQwfYxkonOKX4GL7XOhCMmJ6pCcVgP8zpL4s5eM5b7ARbnnP8VCaO2P5VZi1eLIXRwlJvCLY6i8A5ARJn0bO5e8QEN6uhTwLVreegIYeix_6qmY3-ws9diczbLGcu5GFjS8N_sG82ZHu2Mq56gM16yzKMY7uzKWD8x7FLWDfABMw1UawPmczLVQJ0VTSdg_dTtJfTBl-KaBBJ3a4h0bRnoEjlCFiXDCcyKKoaz2N1r0jeIyrV6akec9P0C3idLKhxiPN2fyxTShBDDnYvn1HeB-mMLqvW6OXucIcUA",
          "widthPx": 4800,
          "heightPx": 2700,
          "authorAttributions": [
            {
              "displayName": "Romain Gagliardi",
              "uri": "https://maps.google.com/maps/contrib/111028030306444745440",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVvoCzRcHgygDCSkv945XSO9FiReJA54S9zXK4tUeBVByUa9CNE=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgIDE8KWYDg&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgIDE8KWYDg!2e10!4m2!3m1!1s0x47f29debc0bfdb2d:0x5c882844f225971a"
        },
        {
          "name": "places/ChIJLdu_wOud8kcRGpcl8kQoiFw/photos/AcnlKN1d6fjvHiqjbSVlGxyj98K_YpM0y9RNy-zc3OJqJCuUtGbanB51W9Z-8l5SJVMaP6OLEvztu71t7bSwPTezKljyV8gXglM5-C2P4iRtXyHY-Jrqg49_EDI_JsLj2z3rRJuTKNGeUUf6bhQxoV1yPiI04WjntPtFi0CXVtYKFtn9gkqmy83jrCPg4ggXn_S9EH5y49j4nEI_kCSqYs0DnWqXVz2wbQUdTuhZoiE7w2vx7HeE3DXVRvIBhy9ByPdbx8HG3uZUzns1lb0E0ACpJpp1GC9CHoX_IC1vmMy8Gv0mRIKyOGqDTH7P91JQ8_xeS8Ys9eVQm9oLivDnUpzDvXLz2QhJq3YUQmnDSTtg26ltPc_8YwwkUx-3cXrDDY5oYIcS6x4HBrg4s3SiaNDkOcvh8itA1zoypQF7GnjnhZL9PA",
          "widthPx": 3024,
          "heightPx": 4032,
          "authorAttributions": [
            {
              "displayName": "Cindy Leblanc",
              "uri": "https://maps.google.com/maps/contrib/101030068511283335825",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocJPObT-JN5tbQ-Ql_KiY_i66G8PtXlDZHSLGctGn8wZSK1Hzg=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgIDNqO2eeg&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgIDNqO2eeg!2e10!4m2!3m1!1s0x47f29debc0bfdb2d:0x5c882844f225971a"
        },
        {
          "name": "places/ChIJLdu_wOud8kcRGpcl8kQoiFw/photos/AcnlKN106bnC2MpaUEP0p8ASIlU8ruFjB7Dckxu39zeK_MbwFcN96TYY5Hn0DV8P6GcCwGzjQ-xkue6AW1d16DGgMqajUppTrN-AXmZpDH01ej5qhcZD2Zes_D5rI7N4xqnXv6nNodUnu1nKZb6LZ56XenP3aB8fOYhzSKBeijY9NZ0XtkQSc4dLwij3ql97Wrluf3fce6ovBNF11aBX6nLGzHzzoTEBxUG8ooSqXn3kI6S_u8s4brW8db_SBEf6G8ceyt2qGfd-iyU4mm1cjMUyBb-QyG1M363kv3ay2tJzuhdV20Z_kV9K5xi1dsVLFWkUCLR1DUCFhtnNel-OWNUykv2ISPj_i7RFEnj5jUi9rSgf1p4AnOFxJaJZmzvVDX6Bg7HQ5a4oXck4P8uNiC41a3yqqNViMC1Mz4iaQHDtF1flfA",
          "widthPx": 2976,
          "heightPx": 3968,
          "authorAttributions": [
            {
              "displayName": "J K",
              "uri": "https://maps.google.com/maps/contrib/104406139880101926579",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocJXqOVw09shoHJ8HZZQNdfv0WbcvjQTOHbX0sgi7H4zja8NsWFB=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgID5qYnQRg&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgID5qYnQRg!2e10!4m2!3m1!1s0x47f29debc0bfdb2d:0x5c882844f225971a"
        },
        {
          "name": "places/ChIJLdu_wOud8kcRGpcl8kQoiFw/photos/AcnlKN2x50BXPpu0rkgmirKxTGU1Asu4x70UqIK7tmFJwefspcoS1AW-tVjY6F_LOZxWjV8EaQzZ55h0U08y2DYlStxBfsM52Pr70xIX1T3n5yDpQayFqO_X7GrgFSlp3EvKM0wrr0abSfLTX5QJ9mHQNtnP_MJGZYX-QOFYnYihDGXPsM2LNY04joSq1CTStdS1qaTJ7YKLW41syl5YmEbWZ3INj6xbZtHj5rOCUy7LkJOii_JJ-beFrluvov9Cc1L-9pQ3FseJHkRnrqNKvemmvQpNRKxCwOHJ5t2ud7FQ06wx0iW820DAO25nmdo5iM_D9iblo2sBUtxNyYSzDDSXAU75Iv_-fqZ3Jj01p5p5hQl0NSZBtm3cdsEbrVuwwvo_iud7PvCR9EqxoTRqY-29Dz4X90UMNaUTTA42WJG8PXtUBN1L",
          "widthPx": 1240,
          "heightPx": 2208,
          "authorAttributions": [
            {
              "displayName": "yasin pala",
              "uri": "https://maps.google.com/maps/contrib/107203081212883185670",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocK7FxRLTu6GNP3F7UF54WTuo6Zl07TyqiQb_mV4FHAT4cwd9g=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgIDZvuj58AE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgIDZvuj58AE!2e10!4m2!3m1!1s0x47f29debc0bfdb2d:0x5c882844f225971a"
        },
        {
          "name": "places/ChIJLdu_wOud8kcRGpcl8kQoiFw/photos/AcnlKN00z-goDplHVLAAE5xKlECP2zZn6PbBAqYABtNQSkr12OgFcK1YhRw_okWn9DDHJTzrLgVJg-sBHRAkWDvQ6ShJKn22TsrqZhx34tAlVjG7krAdQCxy37yDkm3cvxalAgEwzb353_BOdm8AE7tskIOPo9BO4y4AWbBf2HlBkVPyDBgfaoM3LqMtw2L_qsyqtPwfG1mEIOrD9YBVblH1KRYHISk3iQ-Gd7PvING5BzcgZq_hHnqFepVKImc4gI553NgpYYYql_FY6SX0c0-VfJzjSZCe03fgAH2ky_ghFczQyuhu44uhCu3YE7tp7C1RWLDwez8z28xAuUyeN-cykNy_7p8KC968SKD9dW7kieXEI-I8x4HG439EZzx17UQ1FRG8-JbsDuo0F3gcIL6gWX1L_iUYk0XSujVqz6FZW1w",
          "widthPx": 3024,
          "heightPx": 4032,
          "authorAttributions": [
            {
              "displayName": "Marian Bajzik",
              "uri": "https://maps.google.com/maps/contrib/101328234593265486348",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUfc2l2igEz4XGESLhPfd-6lEz7z2Q-bGUeJQCXHAbP2Lg_RF53=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgMDg_L6MJQ&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgMDg_L6MJQ!2e10!4m2!3m1!1s0x47f29debc0bfdb2d:0x5c882844f225971a"
        },
        {
          "name": "places/ChIJLdu_wOud8kcRGpcl8kQoiFw/photos/AcnlKN3HvWm5EvvP7g9r-iAlT8USLJUYeQYI6iCDC-thEz0yAdtfbikMMEdSlzzFAtgBRUrpi2YleNDClB0Z9T_PCNASS47WeQnbFsfKzrCoDBYCIsZ77fCiPioyE9dTrdp582w4TPJ6Gz08QqHntwukzz8eY962aPpmhECLtcADdgjB5J81ui0qxX-WZxLFswT_yRyOSgZ6QWaliAUdFDKE9MdiTF8NzV-Wgs-3ucdyGdh7Y3FWRCQ-JWksENg8sheKTf2_8hcWcS7FrqoFiOe0ctYjn6lg3r_CRGKxKbuGotZaTCnsIFW3eXZ27p1u4a-JZ7vy3CVpdlbu-G_sxnKOPAObEkRSqwgKYP1cNeMPoONkEFIGLiHf24-0IP7HpNIk2vy9uddu784g-_zyZbK8LLdrotCPqhlzgOaa72PejH_N73y8",
          "widthPx": 3968,
          "heightPx": 2976,
          "authorAttributions": [
            {
              "displayName": "Christophe Berger",
              "uri": "https://maps.google.com/maps/contrib/115204057745600001203",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocLGMmXvYXLwlNXBwUM1JZveoCNL75kIU1wvsF4Lzce5uQD0EQ=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgIDksLmqpQE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgIDksLmqpQE!2e10!4m2!3m1!1s0x47f29debc0bfdb2d:0x5c882844f225971a"
        }
      ]
    },
    {
      "formattedAddress": "3 Rue Mably, 21000 Dijon, France",
      "rating": 4.6,
      "userRatingCount": 1471,
      "displayName": {
        "text": "L'Alsacien Dijon",
        "languageCode": "fr"
      },
      "reviews": [
        {
          "name": "places/ChIJN02HOb-d8kcR6tGlcFJ8_SM/reviews/Ci9DQUlRQUNvZENodHljRjlvT21oQ1VtcERUekUyU0RSaWFuVmpZM3BxV2taeWFtYxAB",
          "relativePublishTimeDescription": "a month ago",
          "rating": 5,
          "text": {
            "text": "Great place! Delicious tartes flambées, including fully vegan and vegetarian options. Super cozy place, feels like a typical Alsatian tavern.\nLots of Alsatian wine by the glass of pitchers, mostly organic and affordable.\nExcellent service.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Great place! Delicious tartes flambées, including fully vegan and vegetarian options. Super cozy place, feels like a typical Alsatian tavern.\nLots of Alsatian wine by the glass of pitchers, mostly organic and affordable.\nExcellent service.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Sarah G",
            "uri": "https://www.google.com/maps/contrib/103540650757995107972/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocJCWIqarWZfBrCnym6LhmWL7aWd2OmjXmVm6ewzHqfzYQ6i2Rw=s128-c0x00000000-cc-rp-mo-ba5"
          },
          "publishTime": "2025-12-28T07:54:08.782784447Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT21oQ1VtcERUekUyU0RSaWFuVmpZM3BxV2taeWFtYxAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT21oQ1VtcERUekUyU0RSaWFuVmpZM3BxV2taeWFtYxAB!2m1!1s0x47f29dbf39874d37:0x23fd7c5270a5d1ea",
          "visitDate": {
            "year": 2025,
            "month": 12
          }
        },
        {
          "name": "places/ChIJN02HOb-d8kcR6tGlcFJ8_SM/reviews/Ci9DQUlRQUNvZENodHljRjlvT2tzNVNGVmljRnBFVkVSS1ZqRlBOMVJtWVZKMGRIYxAB",
          "relativePublishTimeDescription": "6 months ago",
          "rating": 5,
          "text": {
            "text": "We went here for dinner last night in Dijon. And I'm really glad we didn't miss it. The service only gets four stars because everyone was really really nice but they got a bit busier than they were staffed for so service got a little bumpy. Otherwise the food was great, the flammenküchen are not to be missed. Really, really creative and just delicious.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "We went here for dinner last night in Dijon. And I'm really glad we didn't miss it. The service only gets four stars because everyone was really really nice but they got a bit busier than they were staffed for so service got a little bumpy. Otherwise the food was great, the flammenküchen are not to be missed. Really, really creative and just delicious.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Dave Schwimmer",
            "uri": "https://www.google.com/maps/contrib/100382247400853019003/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUBa-naV5Sb35I5F4Edl9bHlDXVfc72XkeLfA3vR9C-kaMuIhAgPA=s128-c0x00000000-cc-rp-mo-ba5"
          },
          "publishTime": "2025-07-21T12:46:50.465672583Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2tzNVNGVmljRnBFVkVSS1ZqRlBOMVJtWVZKMGRIYxAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2tzNVNGVmljRnBFVkVSS1ZqRlBOMVJtWVZKMGRIYxAB!2m1!1s0x47f29dbf39874d37:0x23fd7c5270a5d1ea",
          "visitDate": {
            "year": 2025,
            "month": 7
          }
        },
        {
          "name": "places/ChIJN02HOb-d8kcR6tGlcFJ8_SM/reviews/Ci9DQUlRQUNvZENodHljRjlvT2xCU2VuTldWSGRFTlhsRmJGOURNVEZ2YW5CRVJFRRAB",
          "relativePublishTimeDescription": "6 months ago",
          "rating": 2,
          "text": {
            "text": "The tables and menus were very sticky and the whole place reeks. I felt uncomfortable to touch anything. The glasses are placed upside down on the table…and my glass was dirty.\nThere were tables next to us full of glasses and dishes left uncleaned which attracted lots of flies.\nService was slow even though there weren’t many tables occupied.\nThe food was alright.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "The tables and menus were very sticky and the whole place reeks. I felt uncomfortable to touch anything. The glasses are placed upside down on the table…and my glass was dirty.\nThere were tables next to us full of glasses and dishes left uncleaned which attracted lots of flies.\nService was slow even though there weren’t many tables occupied.\nThe food was alright.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "K",
            "uri": "https://www.google.com/maps/contrib/108579276209884747212/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocK5NwLyEC71VUhZtKzUnMC4gfBY6jqDG29YGtx2I6OSO-RcHw=s128-c0x00000000-cc-rp-mo-ba4"
          },
          "publishTime": "2025-08-01T23:26:41.154764358Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2xCU2VuTldWSGRFTlhsRmJGOURNVEZ2YW5CRVJFRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2xCU2VuTldWSGRFTlhsRmJGOURNVEZ2YW5CRVJFRRAB!2m1!1s0x47f29dbf39874d37:0x23fd7c5270a5d1ea",
          "visitDate": {
            "year": 2025,
            "month": 8
          }
        },
        {
          "name": "places/ChIJN02HOb-d8kcR6tGlcFJ8_SM/reviews/Ci9DQUlRQUNvZENodHljRjlvT204eWVUUnNUVXRFUkhreWNrNU9WMUZHYldsV1JuYxAB",
          "relativePublishTimeDescription": "3 months ago",
          "rating": 5,
          "text": {
            "text": "What a great find!  We shared a vegetarian flammekueches, a glass of wine each and profiteroles each. Food was excellent. Service a tad slow but they were extremely busy for Sunday lunch and a group of 30+ arrived but we managed to get our order in before them. Very friendly  staff with excellent English which we needed. Highly recommend",
            "languageCode": "en"
          },
          "originalText": {
            "text": "What a great find!  We shared a vegetarian flammekueches, a glass of wine each and profiteroles each. Food was excellent. Service a tad slow but they were extremely busy for Sunday lunch and a group of 30+ arrived but we managed to get our order in before them. Very friendly  staff with excellent English which we needed. Highly recommend",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Jane Jones",
            "uri": "https://www.google.com/maps/contrib/117243798950759495596/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocIwoTdI0k48S1oiADu70Z8Gq3bR1eR_Qskh-urlP2WeU2UV8A=s128-c0x00000000-cc-rp-mo-ba3"
          },
          "publishTime": "2025-10-26T16:17:10.121425487Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT204eWVUUnNUVXRFUkhreWNrNU9WMUZHYldsV1JuYxAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT204eWVUUnNUVXRFUkhreWNrNU9WMUZHYldsV1JuYxAB!2m1!1s0x47f29dbf39874d37:0x23fd7c5270a5d1ea",
          "visitDate": {
            "year": 2025,
            "month": 10
          }
        },
        {
          "name": "places/ChIJN02HOb-d8kcR6tGlcFJ8_SM/reviews/Ci9DQUlRQUNvZENodHljRjlvT25VMGRsRkRObXhtYjJoeFZHaEJNV1JYZFZkTlFrRRAB",
          "relativePublishTimeDescription": "6 months ago",
          "rating": 5,
          "text": {
            "text": "We had the Flammkuchen, which was absolutely delicious. There were various options available – from traditional styles to more creative combinations with unique ingredients. The service was friendly, and the prices were reasonable. We paid around 50 € for two people, including two Flammkuchen and two cocktail and desert. Definitely recommendable!",
            "languageCode": "en"
          },
          "originalText": {
            "text": "We had the Flammkuchen, which was absolutely delicious. There were various options available – from traditional styles to more creative combinations with unique ingredients. The service was friendly, and the prices were reasonable. We paid around 50 € for two people, including two Flammkuchen and two cocktail and desert. Definitely recommendable!",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Najuraas",
            "uri": "https://www.google.com/maps/contrib/106452459335927983044/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocKFyXkl9xppFJnzF98V6tEgeysoPcEB9Ui6GEFEnmKThU0WLw=s128-c0x00000000-cc-rp-mo-ba4"
          },
          "publishTime": "2025-07-13T07:54:52.930884397Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT25VMGRsRkRObXhtYjJoeFZHaEJNV1JYZFZkTlFrRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT25VMGRsRkRObXhtYjJoeFZHaEJNV1JYZFZkTlFrRRAB!2m1!1s0x47f29dbf39874d37:0x23fd7c5270a5d1ea",
          "visitDate": {
            "year": 2025,
            "month": 7
          }
        }
      ],
      "photos": [
        {
          "name": "places/ChIJN02HOb-d8kcR6tGlcFJ8_SM/photos/AcnlKN305J9Zk08oIPT9Ok9qm3e7u36HCj2bJE7CAr14to6x76jjYV6BFJISau10KVMi9OgwpWx2bbW4C5p0PLZYiwrclsZEPq_H6l-JezxIX5uD66WRvSJkj4pYBrO0WvN6naUIAislDkmZr1s972iI5Brs_N0Cipp-9pXL2b0mW9zGUIa-x9hVojEyudcMgZrbeuX4jxlHPcgP7wpgQCpCIrtKEDyabQ5epdFSxDv1Rpagq_FO_1yanVmgrKURI9K8A7UqznSi0w9asrPZQkSVuUJker_XU4kLziHTVH8zyqjzpA",
          "widthPx": 1179,
          "heightPx": 665,
          "authorAttributions": [
            {
              "displayName": "L'Alsacien Dijon",
              "uri": "https://maps.google.com/maps/contrib/111116438898105122633",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUlAFNdpdkD1KuaYhRlyordRCbF55lDazC1-N7dldD1hNTTBl8C=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipNf4MoShps8HnRvSYHQo00TjpraviL3rofLibZ-&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipNf4MoShps8HnRvSYHQo00TjpraviL3rofLibZ-!2e10!4m2!3m1!1s0x47f29dbf39874d37:0x23fd7c5270a5d1ea"
        },
        {
          "name": "places/ChIJN02HOb-d8kcR6tGlcFJ8_SM/photos/AcnlKN0jfKcR5b_oqKEUajG5PBOmFu4nzUO_smHuTMLBVd9MJEy2EybEzNBukbAYXUub6Ml9cLW-hZAnP5jSs3YCHoiSKyRB7dn3AC08rFp5xYpwqRFz_YMDERf8Py7n3tJVW_x6buIbCdv2RwixC_bFkhyFN5-t57inqdi7lrRD9df7vAS1RqDB7WdTecLJ-11qGJmFmPRyKN6cqrzhysaHledl-pFSbHBNDKZ9IuVxpGeAs_ZBVAUDY_tawXdNIXSZ06bA3if0OKe48Vh_ZWyJqlVp1jxwlKKG4KyeAxLZEJrjeQ",
          "widthPx": 3199,
          "heightPx": 4800,
          "authorAttributions": [
            {
              "displayName": "L'Alsacien Dijon",
              "uri": "https://maps.google.com/maps/contrib/111116438898105122633",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUlAFNdpdkD1KuaYhRlyordRCbF55lDazC1-N7dldD1hNTTBl8C=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipP3LDFIHM9DZNX3uD26YqFxmEpgbIzopyTksKOH&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipP3LDFIHM9DZNX3uD26YqFxmEpgbIzopyTksKOH!2e10!4m2!3m1!1s0x47f29dbf39874d37:0x23fd7c5270a5d1ea"
        },
        {
          "name": "places/ChIJN02HOb-d8kcR6tGlcFJ8_SM/photos/AcnlKN2ujt5aIXadMWHtHWXbfE4I25Ughvzn59lC87Q-HvrKcDCFz27hX69cf-O-ZtqWVM5RNMJaTub1Ig0U74lttn1YN9quIaP8Sx7AHDFvc-nNQhqJ1CAR8thz5GhKh_ByVi0DBB5lO67VvI_vT89F5kcwzfyNyYHJHAAL3gj4cr2dJOlj4HActtFiIUaGxUvB41HDO5v0f9HPiy_rr23VudQ_oFfL8WbxBocH8Isl-OgyD5mh1JLN7I8plu2X0bimSdwpFLJdRMonRpcB0i5atXq39O5m5v06BN55kvAZwR5bfQ",
          "widthPx": 656,
          "heightPx": 662,
          "authorAttributions": [
            {
              "displayName": "L'Alsacien Dijon",
              "uri": "https://maps.google.com/maps/contrib/111116438898105122633",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUlAFNdpdkD1KuaYhRlyordRCbF55lDazC1-N7dldD1hNTTBl8C=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipMiNuxZOQyht3FRrJW2UhPi9s0RbfnJcK9_3LFx&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipMiNuxZOQyht3FRrJW2UhPi9s0RbfnJcK9_3LFx!2e10!4m2!3m1!1s0x47f29dbf39874d37:0x23fd7c5270a5d1ea"
        },
        {
          "name": "places/ChIJN02HOb-d8kcR6tGlcFJ8_SM/photos/AcnlKN0hYXMhWGHxgtx4KjmUCqAo10KQkxTJlFIKv6zaQd4f5OT3ZtQmYvn_y1S7n4kak0tHr9tIiHd9LWjhBMWoE49yOrIYDKighyZqrwZ5KSUaKm1H_T07AJWCJkasomMYcNm7lllNRtxRj_Qr4ygrOR7ttJk9wrbgbphT0oKcV0riQxKgU21Tn0-8zdhsqLH-lTI5RPAfbbpx8nd-8eghy4Zo05_Qk8oNnYK3811u4mej-7C-E27ET85LG9hN14kryFifqNmPmD0VUsRsapDXYHjtazQ7pLaD_nomgB_rPFia2hyrWYsDSswQ774zptv6OvGzP6Bh4qt4YCUfDMelrYKMQQeDOdBK1VEtc2TIif-lcyYa6DlxF56ybJRfbt76PBTs6CnXl9FcVyllH9H9Z3j8t9-bZWUfKcj6OPWGYiH2ng",
          "widthPx": 4800,
          "heightPx": 3600,
          "authorAttributions": [
            {
              "displayName": "Jimmy Fu",
              "uri": "https://maps.google.com/maps/contrib/102834926495080777984",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXlfxJGn9-UJU9j1dESotjsE1AwDNhmxPpwOnJYBhMynnE4Bd_V1g=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgMCIwdeyOQ&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgMCIwdeyOQ!2e10!4m2!3m1!1s0x47f29dbf39874d37:0x23fd7c5270a5d1ea"
        },
        {
          "name": "places/ChIJN02HOb-d8kcR6tGlcFJ8_SM/photos/AcnlKN1NA2vfN-pXeRfOuInf7-ec9S_rLthdyGLweTTH8BXQPLjJUVYV3pcrs58TWsv9ImwIBwCGCrD_fVJCBULSYZzqMA-2EhqsorSYK6HTPm2rQY-z28bEfBT5OJoBUO6OLPxHEqtbxGH-fiM88qKWfMcia4FyZW6L78_uBh-8dpsnfM_iH2RKc68et6Jn9l3iYOUQNTACP0sKresBPKMKX-OG-q0zvvaZEYZiHmzBQLSpCByO_9ToVR1CVKww0woRVW777Fhe42QOvphZiDyxqNKIKRzdhzAPBa2PoJL6tSC5Pawc4I2s5vguTM-MViwJ1BRIl2jod14-cepuBdFa4e0RzUJRqi2pXbXc6IiXg0AJu2THQoHs9EY3zNMe2JgcfCCtNKrRZF9uNUfbi8AfXJ9HaJl_08hDHkeGXh7bMqts6zlexxlhwlZQeXIG8A",
          "widthPx": 4080,
          "heightPx": 3072,
          "authorAttributions": [
            {
              "displayName": "Dave Schwimmer",
              "uri": "https://maps.google.com/maps/contrib/100382247400853019003",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUBa-naV5Sb35I5F4Edl9bHlDXVfc72XkeLfA3vR9C-kaMuIhAgPA=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhC3kZF46fLeMCEQ1Lg40F2o&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhC3kZF46fLeMCEQ1Lg40F2o!2e10!4m2!3m1!1s0x47f29dbf39874d37:0x23fd7c5270a5d1ea"
        },
        {
          "name": "places/ChIJN02HOb-d8kcR6tGlcFJ8_SM/photos/AcnlKN1O27sjixazs9X9ibxJ574kmf99Dmeq_uqsPtgVpGPPVr_MLVpFmmBtaBvd6rfqCAHaN7FZ8AV3tIb0F9wV4oJnV_o7K9pZXnQNqmxkKmUkZ9iVpxq7VtscVfDIiVjetLkxVrpKr5vBb77dLhJjfoA4XAJwempjaMzAJ-LxlTLgUeiSjAcefri8MBtgj0fnkdOD7qdU6JWHMKKn_aOIu5ivFgbaqoeHAs7ePRD8XlPOajWmZ_wyibYIso81OPfSnFK6kFg-E2sYqJn09FBtd6BIKPQn0oNfGBWvdr2mv4pIjUyBK2B4CoxJ02z32c0mwOo95g5hlQnOtJ-1LYv8Gxgf-wB3GhU34TXp4CoeQq6rYY6U2RBICloKZycP7ThoD6MBRG_fNWfG3l8MqKcOzPGMFL6goX4_shAj-7a4GRrCHtJb",
          "widthPx": 4800,
          "heightPx": 3600,
          "authorAttributions": [
            {
              "displayName": "Mobile Car",
              "uri": "https://maps.google.com/maps/contrib/107398484197655714074",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocL7WPUEtTBGabf2EAO9erRs-AMyF14HEagfkpS0z5Asm2m2dQ=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEKf4l8THofap0gE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEKf4l8THofap0gE!2e10!4m2!3m1!1s0x47f29dbf39874d37:0x23fd7c5270a5d1ea"
        },
        {
          "name": "places/ChIJN02HOb-d8kcR6tGlcFJ8_SM/photos/AcnlKN011daAiZmACUfSFHyEowIT9vzV25yH36VinusXL4RBiOljBUwnINQ9BtNOl1C9jA5IlKyXzta05PW2By8t9DV62CTaYgwew3D2BWbd_2PsSQduTVJoRitLR-94DYRs4rydP3tPlCRmwTSDSazoW7poYq0nhz40QNyvRwH7Ohj_5gbagTj6GrJiZcWml6XdoSDB2JEgkjG_54tIEu_sccPVb1NVnOvqfXvUu1EuSKW2fq3XrK9OO2oU-FzqIdVfqI3bmQLarHd8kpGlBxBgynYBpdha1uPiCS_2WC_j1VN_GA",
          "widthPx": 642,
          "heightPx": 692,
          "authorAttributions": [
            {
              "displayName": "L'Alsacien Dijon",
              "uri": "https://maps.google.com/maps/contrib/111116438898105122633",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUlAFNdpdkD1KuaYhRlyordRCbF55lDazC1-N7dldD1hNTTBl8C=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipNKMX5KaTkWjbhC9X9z9JIh0nakp7yGW_ZHKFAX&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipNKMX5KaTkWjbhC9X9z9JIh0nakp7yGW_ZHKFAX!2e10!4m2!3m1!1s0x47f29dbf39874d37:0x23fd7c5270a5d1ea"
        },
        {
          "name": "places/ChIJN02HOb-d8kcR6tGlcFJ8_SM/photos/AcnlKN2oJUdZus9UN4g9Akcgm-tATyvvlE6lKxEiQVTvN06zOegtlNkhqrG7k_shVS3qb9kDmjuvY8tt07N1KDKbi6mKtl4bRkWA4PzeRlGxGTo0d6PbBFvW4_5iqhMfdinkdRB71TUCzDho_WPxMBmmM3_SLZtYOBP16a1ZvnxHZuAR9lvhjzMyL3lP275nh1wp5BWcJOaY7tCYl00LSw8VBEbA_z8x2gK62er33DPy1bevvBwxJQcrbbJfECLkW-0sJzbGybERvoapHp89XSqjSLBS9_y5g0hDj2IsTuoejcaHog",
          "widthPx": 962,
          "heightPx": 534,
          "authorAttributions": [
            {
              "displayName": "L'Alsacien Dijon",
              "uri": "https://maps.google.com/maps/contrib/111116438898105122633",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUlAFNdpdkD1KuaYhRlyordRCbF55lDazC1-N7dldD1hNTTBl8C=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipM5elaEJum9S8-D9shEOrm_MVvxZ-jNFkg5wsZF&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipM5elaEJum9S8-D9shEOrm_MVvxZ-jNFkg5wsZF!2e10!4m2!3m1!1s0x47f29dbf39874d37:0x23fd7c5270a5d1ea"
        },
        {
          "name": "places/ChIJN02HOb-d8kcR6tGlcFJ8_SM/photos/AcnlKN3nLyO6te_y8tNnlrgUNwKj3uM1Fd8Zx-DpGT_wkt4LK31vzWBDGFfSLQuFtWOYn_J-bPS4sxIFWtOjHBFKu5DFEhIZWJc3R_ccLej8dHFYGQnmn6mDu931oZnfSd6A_5EPEdMV0wyABsQv2ttHOgpVEEH7Kgul3rrgsRY8DTiNi9pR91GjlfqRWH7nNYi-hVt0Dag3tnUfpN1Ori3NXtSjCpUCw5riZtaLf9V5PmNC8vwTjLQBSwV-jRP3-TrQnBVZNngcV1XnW-LUHsOHOEm_mO7eYg0VCo6GopSkT57gLw",
          "widthPx": 1920,
          "heightPx": 1440,
          "authorAttributions": [
            {
              "displayName": "L'Alsacien Dijon",
              "uri": "https://maps.google.com/maps/contrib/111116438898105122633",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUlAFNdpdkD1KuaYhRlyordRCbF55lDazC1-N7dldD1hNTTBl8C=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipPYMHVJHy7038HGd1G03X-r2OqPnkWOTwqTmTas&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipPYMHVJHy7038HGd1G03X-r2OqPnkWOTwqTmTas!2e10!4m2!3m1!1s0x47f29dbf39874d37:0x23fd7c5270a5d1ea"
        },
        {
          "name": "places/ChIJN02HOb-d8kcR6tGlcFJ8_SM/photos/AcnlKN2ugqApl1rzDtiWk-0epcHn_cSeMDL3ZK6T0h73min1snOdSqk04TlrtrlPk0NoU35Ko0elZUeRQTsC7jYR6mgCJb-9AZ9hAKjcc4eEWmtzGrdPqX5Jd6FGosEtryBPhy0STVszSFuPz3fKjKZq3tQGuoMGljgFL7Ts7elWC9WgLQVSK3E0FHivAjyi-0hNsYHGEoc0Ybo2yq8H55gLhkMIB1G6y0HY52l331Rvo42Td_kFqWLqCkEG9pr7uxnnU8heyVTcvFd-Zsw655WIsLf_Diw1ewlfXuIDwSBYGMDHBo5635pvUe4DIqg8R_esfqghH8Fhg_9UG2QKsXI4WsaQwfIBTO5LAkYll0UHcI5WrOzKkQElhm6R_2BMY0YKZss2DVT4SKTZWzWMTynKajV-ljDtVNn6q6JEQrpzcHsRdHqfUHbpAmpaJ8t0P51J",
          "widthPx": 3024,
          "heightPx": 4032,
          "authorAttributions": [
            {
              "displayName": "deborah Frg",
              "uri": "https://maps.google.com/maps/contrib/113305255426553766338",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUoKCrGMiUY0bN-QM4kAb4BefUYOjLZezLBIns0u0JudimWJht7=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhDU9QTysXBeiYza3LHVAnW1&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhDU9QTysXBeiYza3LHVAnW1!2e10!4m2!3m1!1s0x47f29dbf39874d37:0x23fd7c5270a5d1ea"
        }
      ]
    },
    {
      "formattedAddress": "44 Rue des Godrans, 21000 Dijon, France",
      "rating": 4.4,
      "userRatingCount": 3551,
      "displayName": {
        "text": "Lucilla - Le Clan des Mamma, Pizzas & Cocktails - Dijon",
        "languageCode": "fr"
      },
      "reviews": [
        {
          "name": "places/ChIJZ5JaKbSd8kcRx2B2YU-kcaA/reviews/ChZDSUhNMG9nS0VKN2RqYXVQcnRMc0d3EAE",
          "relativePublishTimeDescription": "8 months ago",
          "rating": 4,
          "text": {
            "text": "American Tourist review:\nStarting with the food, it was great! The pizza is very Italian style with unique flavors. We got the Gabriella, which was my favorite and the Mia Nonna. Both had fresh ham. We got the spaghetti and meat balls which were very good. The ground beef from the meatballs had good texture and the sauce was good. The noodles are thicker and more filling. We also ordered the appetizer platter which I recommend as well.\nBeing a pizza place I did think this restaurant would be more family friendly but our noisy baby was not appreciated. We got a lot of dirty looks from other patrons and some staff. With that, bring a kid who is ready to eat at a restaurant. They do have a small kids menu.\nOverall I do recommend this restaurant for a sophisticated authentic Italian pizza experience.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "American Tourist review:\nStarting with the food, it was great! The pizza is very Italian style with unique flavors. We got the Gabriella, which was my favorite and the Mia Nonna. Both had fresh ham. We got the spaghetti and meat balls which were very good. The ground beef from the meatballs had good texture and the sauce was good. The noodles are thicker and more filling. We also ordered the appetizer platter which I recommend as well.\nBeing a pizza place I did think this restaurant would be more family friendly but our noisy baby was not appreciated. We got a lot of dirty looks from other patrons and some staff. With that, bring a kid who is ready to eat at a restaurant. They do have a small kids menu.\nOverall I do recommend this restaurant for a sophisticated authentic Italian pizza experience.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "A F",
            "uri": "https://www.google.com/maps/contrib/108506475863498729804/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWwO71JMaYOn32ByvBbMGj5EegPci0fh7ulhPHPC3LnnsGWDEA=s128-c0x00000000-cc-rp-mo-ba4"
          },
          "publishTime": "2025-05-28T07:58:51.072688Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChZDSUhNMG9nS0VKN2RqYXVQcnRMc0d3EAE&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChZDSUhNMG9nS0VKN2RqYXVQcnRMc0d3EAE!2m1!1s0x47f29db4295a9267:0xa071a44f617660c7",
          "visitDate": {
            "year": 2025,
            "month": 5
          }
        },
        {
          "name": "places/ChIJZ5JaKbSd8kcRx2B2YU-kcaA/reviews/Ci9DQUlRQUNvZENodHljRjlvT21WT2FUQTRORXBoZWpWd1JtNVJZV3BPYkVkUmFIYxAB",
          "relativePublishTimeDescription": "a month ago",
          "rating": 5,
          "text": {
            "text": "Had a wonderful pizza here and great lunch. Really recommend, good ambiance and wonderful place!",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Had a wonderful pizza here and great lunch. Really recommend, good ambiance and wonderful place!",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "L.D HL",
            "uri": "https://www.google.com/maps/contrib/110976698283358542691/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocI9zYT-jitWua-tirdmzrO4pv9DFEnfVU-IxoLOxsFVdKOz=s128-c0x00000000-cc-rp-mo-ba4"
          },
          "publishTime": "2025-12-19T16:32:39.863597976Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT21WT2FUQTRORXBoZWpWd1JtNVJZV3BPYkVkUmFIYxAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT21WT2FUQTRORXBoZWpWd1JtNVJZV3BPYkVkUmFIYxAB!2m1!1s0x47f29db4295a9267:0xa071a44f617660c7",
          "visitDate": {
            "year": 2025,
            "month": 12
          }
        },
        {
          "name": "places/ChIJZ5JaKbSd8kcRx2B2YU-kcaA/reviews/Ci9DQUlRQUNvZENodHljRjlvT21OU1JteDRObFJhYUZaVGFHMXpRMWhhZEdkTmRWRRAB",
          "relativePublishTimeDescription": "6 months ago",
          "rating": 5,
          "text": {
            "text": "We came for our last evening in Dijon with a family of 4. Lovely place, great and quick service. Food was fantastic and the ability to order GF pasta was one of the main reasons we booked a table. Highly recommend",
            "languageCode": "en"
          },
          "originalText": {
            "text": "We came for our last evening in Dijon with a family of 4. Lovely place, great and quick service. Food was fantastic and the ability to order GF pasta was one of the main reasons we booked a table. Highly recommend",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "H RUDYK",
            "uri": "https://www.google.com/maps/contrib/113827176073917846270/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocI6l3PPOM9WEp4c6JUHluGxWHbuxamKECGPyEg-nOkhXbonYA=s128-c0x00000000-cc-rp-mo"
          },
          "publishTime": "2025-08-04T05:51:26.709877933Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT21OU1JteDRObFJhYUZaVGFHMXpRMWhhZEdkTmRWRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT21OU1JteDRObFJhYUZaVGFHMXpRMWhhZEdkTmRWRRAB!2m1!1s0x47f29db4295a9267:0xa071a44f617660c7",
          "visitDate": {
            "year": 2025,
            "month": 8
          }
        },
        {
          "name": "places/ChIJZ5JaKbSd8kcRx2B2YU-kcaA/reviews/Ci9DQUlRQUNvZENodHljRjlvT2sxdVJ6VXhWMmN3UzA4dFRVdDRRa1ZwTW5kb2NGRRAB",
          "relativePublishTimeDescription": "5 months ago",
          "rating": 5,
          "text": {
            "text": "Amazing food. We all loved our pasta. I had the truffle pasta. Was best pasta of our trip.  Great food and service. Thanks",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Amazing food. We all loved our pasta. I had the truffle pasta. Was best pasta of our trip.  Great food and service. Thanks",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "eliot Alstrom",
            "uri": "https://www.google.com/maps/contrib/115047822998855288373/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocLNT4k1DxzO0lVRPdF8_vEcjneeKPvq54eeVfy7bFxbpMH3eA=s128-c0x00000000-cc-rp-mo-ba3"
          },
          "publishTime": "2025-08-12T12:31:54.650893208Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2sxdVJ6VXhWMmN3UzA4dFRVdDRRa1ZwTW5kb2NGRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2sxdVJ6VXhWMmN3UzA4dFRVdDRRa1ZwTW5kb2NGRRAB!2m1!1s0x47f29db4295a9267:0xa071a44f617660c7",
          "visitDate": {
            "year": 2025,
            "month": 8
          }
        },
        {
          "name": "places/ChIJZ5JaKbSd8kcRx2B2YU-kcaA/reviews/ChZDSUhNMG9nS0VJQ0FnSUNadU1xd0VREAE",
          "relativePublishTimeDescription": "2 years ago",
          "rating": 4,
          "text": {
            "text": "Mixed opinions about this place.\nThe cocktail and the pizza were nice but there are so many bad details that made our experience wrong that we couldn't even enjoy the food that much.\nFirst, the wait time for horribly long. A pizza takes 5 mins to prepare and cook. We ordered pizza for our whole table, so 9 pizzas. We waited for 50 minutes in the patio enduring the heat of the 1PM sun. No fan, no air, no comfortable seating and no waiters to update and check on us. It really felt endless.\nOnce the food arrived we were so hungry that we rushed our pizzas and did not even properly enjoyed our food.\nWhat I can say on the pizza is that 1. The mozzarella is not actual mozzarella. And 2. The pizza crust is way too large and undercooked.\nI found all these weak points quite disappointing for this place because we can see that there is a huge potential in making this restaurant great.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Mixed opinions about this place.\nThe cocktail and the pizza were nice but there are so many bad details that made our experience wrong that we couldn't even enjoy the food that much.\nFirst, the wait time for horribly long. A pizza takes 5 mins to prepare and cook. We ordered pizza for our whole table, so 9 pizzas. We waited for 50 minutes in the patio enduring the heat of the 1PM sun. No fan, no air, no comfortable seating and no waiters to update and check on us. It really felt endless.\nOnce the food arrived we were so hungry that we rushed our pizzas and did not even properly enjoyed our food.\nWhat I can say on the pizza is that 1. The mozzarella is not actual mozzarella. And 2. The pizza crust is way too large and undercooked.\nI found all these weak points quite disappointing for this place because we can see that there is a huge potential in making this restaurant great.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Loulou's Picture",
            "uri": "https://www.google.com/maps/contrib/106478905025168124929/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVXevqfcJKSVrSO5FIFs5qT2hvZ2iILItXZ-4ozmMp3hvLXJf9k=s128-c0x00000000-cc-rp-mo-ba6"
          },
          "publishTime": "2023-09-03T22:21:23.141540Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChZDSUhNMG9nS0VJQ0FnSUNadU1xd0VREAE&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChZDSUhNMG9nS0VJQ0FnSUNadU1xd0VREAE!2m1!1s0x47f29db4295a9267:0xa071a44f617660c7",
          "visitDate": {
            "year": 2023,
            "month": 8
          }
        }
      ],
      "photos": [
        {
          "name": "places/ChIJZ5JaKbSd8kcRx2B2YU-kcaA/photos/AcnlKN0ADeNMqbb5ZRxdonpAxQNA2r35XQfWrOv6ZOt3rvbAyHUkYO5z-nIB1w-_pblixjpX-Asp7i442Hnh4LSlt8R3ppAR56_ordDY_1J_tAAno6ulHT2tHY6ATeNt_z8ACglmFWao-H1Ay6KefWH_wMJ65XhLZuAoH48lbnIrmiszGwtjiAByu2INHf3ELIicVk3CXuLf8UXbvI-_ByFKG5MNDyE6y-Ga1L7CTPGew5dUEAh1ryG5-0SZDIRRQiZFDqrmh9T75uH1YGc11IZNtMwJemwFeQbd7RnDZZ2q1B1_2w",
          "widthPx": 4800,
          "heightPx": 2700,
          "authorAttributions": [
            {
              "displayName": "Lucilla - Le Clan des Mamma, Pizzas & Cocktails - Dijon",
              "uri": "https://maps.google.com/maps/contrib/106624663176384471586",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWSKUNY2x0GF0_3z6h4XqFwNzVIEtZG-o2mVRZTA7HvOcGGN8u8=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipNvsxvsc7X2WE-edd5z7rDNPL1RKxNYHVw54_Jq&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipNvsxvsc7X2WE-edd5z7rDNPL1RKxNYHVw54_Jq!2e10!4m2!3m1!1s0x47f29db4295a9267:0xa071a44f617660c7"
        },
        {
          "name": "places/ChIJZ5JaKbSd8kcRx2B2YU-kcaA/photos/AcnlKN1S5sw8QLtUL1jXjB9kZrz_pBmUHJnKZqpCxmfiAQVhMsqXYnnAGfhTp1HN0uTxGjqUDcLawemp4M2xsZ1OJbRavPacxdFKrbIWghp7NWrWZjvFjASCR8rcmWgVhe_k_jYSfatqy4GJ6PqUSmYyjOdI64S3vSY3HEKWkC5v4IbbdRKhoujh3UK5OEIz1LJn8U0h_d6lKWfIcFFoUbPrQOntXo76h7GfgdgJb-rCrFy_0Ms6AdVcXhSQrSKds_H1x7fyW9wbk65tFumbGckQcxIlvISOON9DNYgcX6U63UmnoA",
          "widthPx": 3744,
          "heightPx": 4680,
          "authorAttributions": [
            {
              "displayName": "Lucilla - Le Clan des Mamma, Pizzas & Cocktails - Dijon",
              "uri": "https://maps.google.com/maps/contrib/106624663176384471586",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWSKUNY2x0GF0_3z6h4XqFwNzVIEtZG-o2mVRZTA7HvOcGGN8u8=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipOKRsVfFupvBakhvi_xoIUYkhTrXqhzS-EjeyCy&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipOKRsVfFupvBakhvi_xoIUYkhTrXqhzS-EjeyCy!2e10!4m2!3m1!1s0x47f29db4295a9267:0xa071a44f617660c7"
        },
        {
          "name": "places/ChIJZ5JaKbSd8kcRx2B2YU-kcaA/photos/AcnlKN13ob1yqj8jGKsfsKfkOWwWL0zBfSvCxOIwNtZt2rHoyJKNzp3VGHyZWw53v2YOOK2XOlRYF-iHIJVHpSZJVDtfDQqsYV2echFYwdtqO2eJN-AZDOIfRwcTclYJ-1GOg_0XeekqBTnK-rBxxIn_MxdCzA2TpPTeJ7L3AWfNNYCOTAk59zghyqbDjhdoyYjqG6HxkuftOOHwN2o-P-mmbUOntRJn-SX_jE2NhANHhIiyOp-kWa1-fjQf2zoU6CAncgYNtELpbtCTzIHhxreXLPoNCBH3FDCDo1_Sf-Pq-KDtCNQNH-vwJFqouUs0Wb52Ms0bw7PlsTj-Iq-1xys1XRtzsefEmGHwlz7FwIcsFjkrKcfwOSL17KLmomJajdNRZX6_LYl0XI_ASM7yW8lulU7RGB64szUY3nCPSKFhNky7M7HN9SdoQIgOru_WMGcH",
          "widthPx": 3600,
          "heightPx": 4800,
          "authorAttributions": [
            {
              "displayName": "Léa Martin",
              "uri": "https://maps.google.com/maps/contrib/101791969757017412671",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUKLoa5_4VrI6aVO7EzkP8yTBi-Hz8x7SiDkd5XseJkoMIAOaE=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhCvSfe3p1Fon8IRISpFGZ1o&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhCvSfe3p1Fon8IRISpFGZ1o!2e10!4m2!3m1!1s0x47f29db4295a9267:0xa071a44f617660c7"
        },
        {
          "name": "places/ChIJZ5JaKbSd8kcRx2B2YU-kcaA/photos/AcnlKN1tBmJeu0WhREnBHuM6SsbnJlj2GCva5Veiz5tc4BjSMcbhmzpM8iGEMRWDAvoeYRRdt3GvjS0JJq5ORVrJCCVpjt269NnyMXentxaxDSSpu8JL-5PYpmz95JguRp0HKuiRX5pNxwlK27avoUPDwIjll8di52G8-ycPFjUhlKQ0P7hLHu8Fo6489WzO46sQa_UErTwz4yqTh_TFv8jKWoteR4SwX_eW0HxN5uch0Ldcaz0zqje3J0mz4GnCpBXp2dce3tLkYQUyNMgWt4xPEikG6VpOa4iVIMdMPqpH9fTtWScvX7q8xJQedpDfNG8VKe7eOQbT2IHu5eE87wt07Tl1X7gF9El7d_9XQj8lO8kbB-I7R-Q-XoaQX-TwdYgoLkK3xTfv_ktVIKt-dlmUXQ7onxg6nhahSccMPr9GVXQkAGZ9ijHciTFn6Urmwg",
          "widthPx": 4080,
          "heightPx": 3072,
          "authorAttributions": [
            {
              "displayName": "Jerome LAFFONT",
              "uri": "https://maps.google.com/maps/contrib/112153606987888616949",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVPJBRR3I6fNfLsweDL-cvWioqSsrbwrIwjR7kTOeVa0nlBdtQS=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhA7D2-fEe3G-SNhrk4M1DVe&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhA7D2-fEe3G-SNhrk4M1DVe!2e10!4m2!3m1!1s0x47f29db4295a9267:0xa071a44f617660c7"
        },
        {
          "name": "places/ChIJZ5JaKbSd8kcRx2B2YU-kcaA/photos/AcnlKN3SlPF2ew-4XsNhXCifyeBJK7Vgr6npelh-r9b9NwQocY19layLK3CMP92hrZvcQTtJWNOurzJFvPo0_s1cNNP2qmWlPR8iE12wxFlNLR2FrAjFb0og9JFkKteFiTVvvBkHIVzbo3oHx0N5_rgL4LRdUizkaaiISOcEasKar-Z2Cl5gbTjR8uFR_SlXStJR_im-89i9ttB1PWZb2aN-Ksz3ivGTCvhqYFWyMXkATG8IswSyl5qKek3OSa7zUJXhqVQIJMMt9D1bKOI28YdcxX3Jtreg5ZhgMUnIwpzhjCOdlA",
          "widthPx": 3744,
          "heightPx": 4680,
          "authorAttributions": [
            {
              "displayName": "Lucilla - Le Clan des Mamma, Pizzas & Cocktails - Dijon",
              "uri": "https://maps.google.com/maps/contrib/106624663176384471586",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWSKUNY2x0GF0_3z6h4XqFwNzVIEtZG-o2mVRZTA7HvOcGGN8u8=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipPJ1_OgMiOxRE7MzOLdCZVFZCJWxtjUKOICunqN&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipPJ1_OgMiOxRE7MzOLdCZVFZCJWxtjUKOICunqN!2e10!4m2!3m1!1s0x47f29db4295a9267:0xa071a44f617660c7"
        },
        {
          "name": "places/ChIJZ5JaKbSd8kcRx2B2YU-kcaA/photos/AcnlKN2Lc8k4bfpfpuOyK02MEq62WIT1sFQ-u6LAfm0CKJxvOus2s0KkDS_morQL1V2dEqUR6yNxR7jCJOdyncntKaGWmqWJ0KRzmXETM3l98hrJh-0JagAegbayJrgCitw4ieVdz1hodIySLOtS3h_OOTK4a-nRg37-Uuy2fSeG_Q3nd7ZZSGkzPkl1ujKiw7BcamuXfWoX9_WDCKKrI8rEcn_sTWi0RxYhv-htYv96hLBg08CROtffaMWTWM-UvkTkYprM2a9cbFtwLHD9uJ7BKSq_6R5FR2fFDEuScrV1_gWi_22yfZH3VSnb6KM7j0lWScHj5Cb0mzsgQkj_6GRJRW7KmVkWurJfsCOTqhcUhM_M29QtV2zKvfLtojgJbx9rRnSoQOZmwb9igzxKMMe8WgNBJOmP1MfgKS2T6MximcMIigs2IQwQkHk-mJcOFw",
          "widthPx": 2268,
          "heightPx": 4032,
          "authorAttributions": [
            {
              "displayName": "Simon Shih",
              "uri": "https://maps.google.com/maps/contrib/106982817364678932862",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXWYph9R3_hPSORwgSjMM9BZhcZD0PE2NWe12_rr1vEzCJFDk4=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhC9FZBDsvyOl_UCTtSjNbEz&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhC9FZBDsvyOl_UCTtSjNbEz!2e10!4m2!3m1!1s0x47f29db4295a9267:0xa071a44f617660c7"
        },
        {
          "name": "places/ChIJZ5JaKbSd8kcRx2B2YU-kcaA/photos/AcnlKN0YSWsx0vFFCl7_1dddjNslLSdc3pX-kvDBTHLfBoospePj74SO1vdSVAhL19qE5wvPPNwzKvuS2fQHxtWEuOxONOg7eOhmJ4TVE9YtCJqlxbWjbzQkJhVElmLpq585Be-X9KUOlQaFMsEBONfgOnUyBGnk-WTgry9qp6N9jMDWJCf-JbtqaJene4FXrAZzbopkaW55nU7wp0UaWchaunHhmnPaX2obDJKcGuj0lNm9DunR7BlL164gvQwHd3y-Jzeo_SeP91Uue7aQxpFMr6Bc-wvkTmh4joWxvOiyLCSznJ6mO5IuajXQ3SK4QXSZ5XuvQICTYzzMyx4tE4Oorc_81ckR6cvdrq3gfqgdKCI4IZvE-eLFhULek-4qKN0I9oQzc5F8mEofJXPIVOo3uKNa77izBM57dWxAWkTcLsU-WMvRuc9lwfaVDmlxEg",
          "widthPx": 4032,
          "heightPx": 3024,
          "authorAttributions": [
            {
              "displayName": "J vS-25",
              "uri": "https://maps.google.com/maps/contrib/101118803968854359526",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocJ8MHskP77AbgZVZPAs95lnELjNoyqAjEqMely1Z5cSvLuS8Q=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhDoS10nLCjQT2Z-acvZJ35A&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhDoS10nLCjQT2Z-acvZJ35A!2e10!4m2!3m1!1s0x47f29db4295a9267:0xa071a44f617660c7"
        },
        {
          "name": "places/ChIJZ5JaKbSd8kcRx2B2YU-kcaA/photos/AcnlKN0-MNn2EhEIdc9iaG2-COyklgUSoIXCK7HKWruZp2386WDLhtBXHzkOwUD9_kFe1dm9w31Cm-oXElJN1sYVBmq0yEHguRDav_HwWgnyuvDLidoZfmng8gA2nqMqapErV-FzgL0K97qN7ckRyWyDarfVjHu1GXcQKYymM-KBTGiU5wEX8JGDrEkNdEK1GcR59pJcA32hg6rwV9cueOa-De2B-gcSaG3PueFbzlzh62LGPXIWeQebx16H43XvKyUNRoUKmkm4tBKoyfbmqJxd9rvEFFv_Y_1Zf1BiutQjxUZ2YQ",
          "widthPx": 3200,
          "heightPx": 4800,
          "authorAttributions": [
            {
              "displayName": "Lucilla - Le Clan des Mamma, Pizzas & Cocktails - Dijon",
              "uri": "https://maps.google.com/maps/contrib/106624663176384471586",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWSKUNY2x0GF0_3z6h4XqFwNzVIEtZG-o2mVRZTA7HvOcGGN8u8=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipN06qZDDsl_3mYJgwOGBKQGmDg5DZRj3NoTIXwb&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipN06qZDDsl_3mYJgwOGBKQGmDg5DZRj3NoTIXwb!2e10!4m2!3m1!1s0x47f29db4295a9267:0xa071a44f617660c7"
        },
        {
          "name": "places/ChIJZ5JaKbSd8kcRx2B2YU-kcaA/photos/AcnlKN0GViX0yYKlSbi7f6QI-9o4F2eS_vet76sW_zmoFgpyUuj4ccjZbDHmLjzZzgysqxN2xvrDzuqL3mOBLxMhOklseTik5X_orx42ZRRRzoVeva2kt0P3J2fvArkLuyGiWFDcIY1Eb3nHCkjyNy5HW3jwj9gtUF1n6_NgGSW4OMeG6gPL78AxZegaqWUlnhcZWMUD6CyNS3XXE6CJuC6lkcAIuy4s7-nAXsy994m9dOkwSC8aT6YZ2qiMKSaeprRdp_wS7BBuU-uCUjHLRfVpIIJ8R2g2ehZV7S2giWtNDGz4yDWQM1ISXhspD4PV21pqaleBYPjYn0wGnnjMvb7MQMYZ5saxyiKBRZCAyUFR57svE32qvce4lXfDSsHqPjXG0abkvumWVHSyENgEPp-SaHdF6Q_N16hbvKBgb41Cov1lgEunijwEqZJ_xZex-rcT",
          "widthPx": 4000,
          "heightPx": 2252,
          "authorAttributions": [
            {
              "displayName": "Bruiser “Bruiser”",
              "uri": "https://maps.google.com/maps/contrib/100449490112647286637",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjV79pL7zvMDmIaucr0uzdvB0dkLSu1uXG6CiA8fPiGustUsYbDXtw=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhAsmv_LcuJ93a87qSRRoopX&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhAsmv_LcuJ93a87qSRRoopX!2e10!4m2!3m1!1s0x47f29db4295a9267:0xa071a44f617660c7"
        },
        {
          "name": "places/ChIJZ5JaKbSd8kcRx2B2YU-kcaA/photos/AcnlKN2Hsfl5NwSz1WtVrdZ7W7SQdgooVllPTRATZkxDlUnXMmRz-xtIOqGuB1WCxx_fjX7DXOokS4r2jS_GX0FB1PQP2KhhaqBD_KYD2FDe4d1OuQSJ3W7PlRJdN-L7L3CywP-F4u9JO2ecf8-UUfzkUKEXOJhc8-Wec43e7IbqzxhmFZutGZErjtMQiumxZI6a_LKIhTMrUWAlZ-kII51_I5gITfMx3rGvyo6VY3KTEKsHk41j4LL2f3cTXvqk4mzboRuqzyaajBPrn8AELAza_qADU9YVCDNS_6--UFJh3J98-bTps1dTptjyqXFvyPcbDxfuq4xD5aYOiLqCTz54r3zIy7gkftH-1Ny_1gDXqSqlJzBKy111VWkmPnsQNqQtiR80uKNQXsOhxRaQsP0CD6spDvWzBLc-kKpHJ5v3Hl6hFQ",
          "widthPx": 2208,
          "heightPx": 1656,
          "authorAttributions": [
            {
              "displayName": "Camille Audard",
              "uri": "https://maps.google.com/maps/contrib/116662733847610149626",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocLk9rrU0GF_ZxUsS386jjQjtRbPVJlj1A-m5fuQ6-if5cU2=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEKfU3Zee0cyPKg&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEKfU3Zee0cyPKg!2e10!4m2!3m1!1s0x47f29db4295a9267:0xa071a44f617660c7"
        }
      ]
    },
    {
      "formattedAddress": "Parvis De L'unesco, All. Alice Guy 12, 21000 Dijon, France",
      "rating": 4.1,
      "userRatingCount": 727,
      "displayName": {
        "text": "Pathé Dijon",
        "languageCode": "fr"
      },
      "reviews": [
        {
          "name": "places/ChIJGyui9M2d8kcR7uXOos0UwmM/reviews/ChZDSUhNMG9nS0VJQ0FnSUNCd0wyeUNnEAE",
          "relativePublishTimeDescription": "3 years ago",
          "rating": 5,
          "text": {
            "text": "Great new and modern cinema, saw a movie in English and it was a private screening:)\nReally comfy chairs, big screen and loud (as it should be!) Audio.\nI dont understand the criticism concerning the ticket price, I find the price more mediocre. I already paid more for less modern and clean cinemas before.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Great new and modern cinema, saw a movie in English and it was a private screening:)\nReally comfy chairs, big screen and loud (as it should be!) Audio.\nI dont understand the criticism concerning the ticket price, I find the price more mediocre. I already paid more for less modern and clean cinemas before.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Groschi",
            "uri": "https://www.google.com/maps/contrib/108446365109450741697/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWAUBMgH_9Tg8YgX67tn-b9NnAKuoeD-QLEXDLCG4DQrdOS_wRf=s128-c0x00000000-cc-rp-mo-ba5"
          },
          "publishTime": "2022-12-14T08:29:29.665974Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChZDSUhNMG9nS0VJQ0FnSUNCd0wyeUNnEAE&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChZDSUhNMG9nS0VJQ0FnSUNCd0wyeUNnEAE!2m1!1s0x47f29dcdf4a22b1b:0x63c214cda2cee5ee",
          "visitDate": {
            "year": 2022,
            "month": 12
          }
        },
        {
          "name": "places/ChIJGyui9M2d8kcR7uXOos0UwmM/reviews/ChZDSUhNMG9nS0VJQ0FnSUNPeTl6V0RnEAE",
          "relativePublishTimeDescription": "3 years ago",
          "rating": 5,
          "text": {
            "text": "English speaking family from Cape Town, South Afridca. We spent 3 days in Dijon during a very challenging heatwave with 2  young children.\n\nWe battled for things to do outside of the heat and this was perfect. We watched the most recent Jurassic Park film and enjoyed it a lot. Good service, great facilities and easy to use. Highly recommended!\n\nRyan",
            "languageCode": "en"
          },
          "originalText": {
            "text": "English speaking family from Cape Town, South Afridca. We spent 3 days in Dijon during a very challenging heatwave with 2  young children.\n\nWe battled for things to do outside of the heat and this was perfect. We watched the most recent Jurassic Park film and enjoyed it a lot. Good service, great facilities and easy to use. Highly recommended!\n\nRyan",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Ryan Bluett",
            "uri": "https://www.google.com/maps/contrib/107692565127173941576/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocKZSS1XYRzIckUjVamPAsD-mfDLne_InKbBNpjaNhEO1fmnDYs=s128-c0x00000000-cc-rp-mo"
          },
          "publishTime": "2022-06-19T20:26:43.623133Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChZDSUhNMG9nS0VJQ0FnSUNPeTl6V0RnEAE&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChZDSUhNMG9nS0VJQ0FnSUNPeTl6V0RnEAE!2m1!1s0x47f29dcdf4a22b1b:0x63c214cda2cee5ee",
          "visitDate": {
            "year": 2022,
            "month": 6
          }
        },
        {
          "name": "places/ChIJGyui9M2d8kcR7uXOos0UwmM/reviews/ChZDSUhNMG9nS0VJQ0FnSURwN0pxOExnEAE",
          "relativePublishTimeDescription": "2 years ago",
          "rating": 3,
          "text": {
            "text": "The screen is not particularly big and the seats do not recline. The range of snacks is expensive and limited.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "The screen is not particularly big and the seats do not recline. The range of snacks is expensive and limited.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Lydia",
            "uri": "https://www.google.com/maps/contrib/111313850621535834487/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocKXghOQnd7lmeNkzX2axYhbDsW8eiClZlz0eamX3efRhUtNaQ=s128-c0x00000000-cc-rp-mo-ba4"
          },
          "publishTime": "2023-08-17T17:27:02.117812Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChZDSUhNMG9nS0VJQ0FnSURwN0pxOExnEAE&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChZDSUhNMG9nS0VJQ0FnSURwN0pxOExnEAE!2m1!1s0x47f29dcdf4a22b1b:0x63c214cda2cee5ee",
          "visitDate": {
            "year": 2023,
            "month": 8
          }
        },
        {
          "name": "places/ChIJGyui9M2d8kcR7uXOos0UwmM/reviews/ChdDSUhNMG9nS0VJQ0FnSUM3aGJiVjh3RRAB",
          "relativePublishTimeDescription": "a year ago",
          "rating": 5,
          "text": {
            "text": "Quite a new building and very comfortable seating.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Quite a new building and very comfortable seating.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Alex Walster",
            "uri": "https://www.google.com/maps/contrib/108571929644373132194/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXGnwGzDASCuORO4Rha67PAn0egRazQCwopGa7Q4Jg6_qxQl5Y=s128-c0x00000000-cc-rp-mo-ba4"
          },
          "publishTime": "2024-08-17T07:54:38.347985Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChdDSUhNMG9nS0VJQ0FnSUM3aGJiVjh3RRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChdDSUhNMG9nS0VJQ0FnSUM3aGJiVjh3RRAB!2m1!1s0x47f29dcdf4a22b1b:0x63c214cda2cee5ee",
          "visitDate": {
            "year": 2024,
            "month": 8
          }
        },
        {
          "name": "places/ChIJGyui9M2d8kcR7uXOos0UwmM/reviews/ChZDSUhNMG9nS0VJQ0FnSURKNTZiZlFBEAE",
          "relativePublishTimeDescription": "a month ago",
          "rating": 5,
          "text": {
            "text": "One of the better cinemas of Dijon centre as they do a lot of films in VO",
            "languageCode": "en"
          },
          "originalText": {
            "text": "One of the better cinemas of Dijon centre as they do a lot of films in VO",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Colin Farrow",
            "uri": "https://www.google.com/maps/contrib/113332247125478919601/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocIlmrx2iqR5Z6CKYihYne6Tgo_NbcTdPUplUxBTedNhta-c_g=s128-c0x00000000-cc-rp-mo-ba5"
          },
          "publishTime": "2025-12-31T07:32:23.668400272Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChZDSUhNMG9nS0VJQ0FnSURKNTZiZlFBEAE&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChZDSUhNMG9nS0VJQ0FnSURKNTZiZlFBEAE!2m1!1s0x47f29dcdf4a22b1b:0x63c214cda2cee5ee",
          "visitDate": {
            "year": 2025,
            "month": 12
          }
        }
      ],
      "photos": [
        {
          "name": "places/ChIJGyui9M2d8kcR7uXOos0UwmM/photos/AcnlKN13yU8_H-VXMWDfhvU3JNgoOIKMX21M_TtpX6YP7ahcn9zRkerc2WOcSCfpMupQOmukc-_KLsJqw88gW9_BhOGkY7C578fuw3pBCT-q2WPpr3JseScNLhK54FWyp5ZhdTnHbdbXqMTYLaFleIuaqS4JQBmgjnqK6G19yBfecSUVfdBsf03PpufIPxub6bFQ4UA9YO-YxR5gkJpYyt6uaoMCTKrJulUt2VCVS6fxD13IpzlLeyHNqKHW67iYz0ePFSitqKmJX-WSevYIhbI_c509D9cxhnOyU8e8LpkoFnFKSA",
          "widthPx": 4800,
          "heightPx": 3200,
          "authorAttributions": [
            {
              "displayName": "Pathé Dijon",
              "uri": "https://maps.google.com/maps/contrib/109409545014841352474",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVPrBy6XKp2oaHU2VERI0E9Gf0VZMqy438t4JsAw89rlyJ7ypbu=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipOzc0m8I9KeOT-sLA8J1eXQfYMEVhLbAWnS51Q5&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipOzc0m8I9KeOT-sLA8J1eXQfYMEVhLbAWnS51Q5!2e10!4m2!3m1!1s0x47f29dcdf4a22b1b:0x63c214cda2cee5ee"
        },
        {
          "name": "places/ChIJGyui9M2d8kcR7uXOos0UwmM/photos/AcnlKN2pkUupYKx3xuSI3rbj53V0ttCaxNrS0EB32mhSF-uo3lONi5sjFv83wOAvhVvAqFZuzXcz3_LQgprZTLXY3ADHZ0LfGYr0G0sKdITel7ohi86dnvVCIyKil8ExSJRZp4Jyno5cGzymxtV97UA9Men-vw-V6K-oXBa2uciDEkvE42K1Q2gVidx98-NIE02WDvMnJfkcPehsrVG-pfWIVAk__e1YnyiyF4v7s_AE8_EylzJ4bUcEbLHvHM3fiCmEvmAkNF95CkkKhMF1tBWSs6mokDqjdpFlAzZINQIqraS9uXtoXnFhg7_wj-W2tpS2Oc1bqXz35KSJPXFiw7Ai1iuxZbrhETJDgahNYYMc5lQckrHJPOXaw-zqXvGrNmLQNzLDvTaE4bi64PULjmiB9fWpCf2StMS4pwBexPRmt8Zk6GeF",
          "widthPx": 4032,
          "heightPx": 3024,
          "authorAttributions": [
            {
              "displayName": "David",
              "uri": "https://maps.google.com/maps/contrib/110855692920681349708",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjV85MdlI5dNf0ePTAsx4I-cboid6xHlOYlIbYzJ07dStq2lVBNB=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgIDeoKmmvwE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgIDeoKmmvwE!2e10!4m2!3m1!1s0x47f29dcdf4a22b1b:0x63c214cda2cee5ee"
        },
        {
          "name": "places/ChIJGyui9M2d8kcR7uXOos0UwmM/photos/AcnlKN2fwB3SaswGg1zXlZynSafLqcSaEkLdePCOfLQQ7ccruRdru4H4E-HFjYXgkKIiQ0egM7pgazCb8-0xb7t6ninJJT1lwCZ4WEN1q2YrIdSZK9fOybgNe25AS3ct_NVQ7aNLyDomutbqyHlB_jxNL1Iiwn2C4l8kUAm52yw6E6m_JRNqrMR3r0OTjGz6qQ7WJufycWg5lhzng9hvMaeH3JZfuCq5x4SUtMg9Wd-5HqT6FOwwpB8_ojv4Blf1FT7i07HXNcL8Oc1vPVTM2ypONhfJPx7nAJkncv4B8OJkgSWUTQ",
          "widthPx": 4800,
          "heightPx": 3200,
          "authorAttributions": [
            {
              "displayName": "Pathé Dijon",
              "uri": "https://maps.google.com/maps/contrib/109409545014841352474",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVPrBy6XKp2oaHU2VERI0E9Gf0VZMqy438t4JsAw89rlyJ7ypbu=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipNkKtIZ1UaHtUxNNOoTPlpqHmnmQtb1RMH1P1Ar&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipNkKtIZ1UaHtUxNNOoTPlpqHmnmQtb1RMH1P1Ar!2e10!4m2!3m1!1s0x47f29dcdf4a22b1b:0x63c214cda2cee5ee"
        },
        {
          "name": "places/ChIJGyui9M2d8kcR7uXOos0UwmM/photos/AcnlKN3Kh4bxiR1pp2WIiOBR55MuZpDleSLptOCSVn6UniMUxmZcIe-omcHA1G9PZwb4RbiLrxQaCCW1IPUNFZBtOmVSQbf-vccy4cyVUlzF5WZN4ogtHMIr_OXOjIFD5rf9u2JYv6ahWWx-Ondq-vfmcFcU09N-dYAWnq4tjrM2ODFMRFvCrYtp22CO0oePCdWFh-JHcGXqn2emamt747bww8Zclfh9TKsnWAe9ftrVCSWh3vUs5uPeFV6xbxzN7c4CShSxlT9r72aWeRtpE5Rn6jIiTE4z34Zsn6JGsudbz314RA",
          "widthPx": 4800,
          "heightPx": 3200,
          "authorAttributions": [
            {
              "displayName": "Pathé Dijon",
              "uri": "https://maps.google.com/maps/contrib/109409545014841352474",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVPrBy6XKp2oaHU2VERI0E9Gf0VZMqy438t4JsAw89rlyJ7ypbu=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipOln1O42qk6-LRQK60HY-QaQG5eZNiuo2AM07By&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipOln1O42qk6-LRQK60HY-QaQG5eZNiuo2AM07By!2e10!4m2!3m1!1s0x47f29dcdf4a22b1b:0x63c214cda2cee5ee"
        },
        {
          "name": "places/ChIJGyui9M2d8kcR7uXOos0UwmM/photos/AcnlKN0tgmcjnPK7F9ianBRW1xJD5GTbdVAeug1yakgo9XJ9jY-R7e6fKVWXeTjEacv7xRuO23-R1qllO0iTik9vth0GI0FPGdrSwpcQUY4EtXcZ2wPfSy9t3spj6bpp_E-A54LtwfhZJSO2YmhH04Adu-OfuquK-grwkC6ufgI1i4cv73WuOUPamqePGZQhrDe2XFsXttiGQrTBW9tmas7RZV0rIw0XA7zncSj2ieSmqaPPshjoui0Rl1Z57p0PVS74BrqVMW3x0qZPmtL-O03YWZE7u4mMI5Q7RqumnrMY_ZLKvEmR8ymv7KmKfawKpLdHhiIZ99gl9dvgwqwmmjAoq4CJR6FzPz8R5CaSNjQWihqlLQzCcRzVQQKW-W5sDToTr6thY20KnLO_jvHA-25FgfdAkHtn9WsP-dZF6DK3Y_QsXVg",
          "widthPx": 2268,
          "heightPx": 4032,
          "authorAttributions": [
            {
              "displayName": "Margaux Lebasi",
              "uri": "https://maps.google.com/maps/contrib/114108379692833376465",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocI7OpDuS_QIW4-bbASgN-gGjowpDQH_6Lu2TA4tQMjZpyLOaUUY=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgIDe0e66jQE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgIDe0e66jQE!2e10!4m2!3m1!1s0x47f29dcdf4a22b1b:0x63c214cda2cee5ee"
        },
        {
          "name": "places/ChIJGyui9M2d8kcR7uXOos0UwmM/photos/AcnlKN3gzkFzQK2ymsf-bPZJd1EnyKk4dp6NvrUX4WyvbL6gkArY4XumOy_k5pxnq4QV4jx9tKsNL-4I-dWI2sBvo1DzY4pJdwb6FSLSxj5yoV2N8OGjN4o2TVR56YyFtwbvpmf50RWALQgzvS2h89LYvCXLzQM1FoU_NCtXEm-E0YAuxXFAQbVEgzTV9vq1npFEeJjIaskLSYPmePbOl_JewdJr0jvewqf-H9xeJygJ8rzppo9wEm_DoAvNfybS9CTK_hLaX8cAUh9mlunHWyD5s6gmG9tdJzVBZcKPVh4AGyafLA",
          "widthPx": 4800,
          "heightPx": 3200,
          "authorAttributions": [
            {
              "displayName": "Pathé Dijon",
              "uri": "https://maps.google.com/maps/contrib/109409545014841352474",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVPrBy6XKp2oaHU2VERI0E9Gf0VZMqy438t4JsAw89rlyJ7ypbu=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipMQQfvEttLsy3XkNoVpAVj49U3qzJ9M9aZim5MV&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipMQQfvEttLsy3XkNoVpAVj49U3qzJ9M9aZim5MV!2e10!4m2!3m1!1s0x47f29dcdf4a22b1b:0x63c214cda2cee5ee"
        },
        {
          "name": "places/ChIJGyui9M2d8kcR7uXOos0UwmM/photos/AcnlKN3vvAo9vDvhIk_d0rfMKRb-G30T49lfrlDgzvwd3ZjSrCIQoLIfGmYcuN7dW_Y7QjYSJSmTWo5vfPmg45Jg9rLiFidtRa6uAyvVtqEc4dz_5qn9qNND8K_3V4aRyMe5i3jT0ae8Lici1TSyzTGLMqLdixtBPbLBogbeLp9ukmSQ5ooJ7bpVPLrMzuGvBw9PnrmuwsuvGD-go2byALW2wo8jMZFC-Oag9LzL3I-b_HRXCWmvub6_SDk4BRfLa5pqpNFfvS1DzrkqKpMoBec-2xiLXu9hLWNBCXW5fnx3TCpuQ0w0q-4A5yruYTIi7LfQcBpK0l-tVbvYMIwxBuCmnIcp0TL-3Bb848h_z_uH9kxeZKv-QwvCTePjfWQI1qKWimomJG9BhC7aZmnAmJHerlYNAgOq6O5rD5Isc9BSEd3YhNkr",
          "widthPx": 3024,
          "heightPx": 4032,
          "authorAttributions": [
            {
              "displayName": "Lucas",
              "uri": "https://maps.google.com/maps/contrib/103809764681821228540",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUXIGIuBEuu-3IxSFTT-QBaRQZ0JzhWmh8gfCMuHnB0F9M1gsc=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgID95em85gE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgID95em85gE!2e10!4m2!3m1!1s0x47f29dcdf4a22b1b:0x63c214cda2cee5ee"
        },
        {
          "name": "places/ChIJGyui9M2d8kcR7uXOos0UwmM/photos/AcnlKN3OFmQ01y8O_AG07jY77CFmqltJU6JX_Ns6h2DGmv1qQnXgPsqBENAOQ9wUXa71577G6ufYUgEh8M6kJg70I0cgOANp4DjqtD7SsAB3NWiEvBpz-qzzLruQnVoMmF_mV08JXkxqfyN45Vp8YSOFnynH3s7Z519cNRP4tTx36uNWjaT2bsgd-iRQ5PGsJCRiyNLMZHUhovUPbXp0Z5VWwGdlf1JKl8iLbztWEOqvwg-7ZJkgHRtm1DGPnUHWRrv0u1F9_t6_DDSbFlhP7GhDOnPu8ZvdD97PCGsh9K7si-cgUD5L8vXWFX1-bwT0tEQwkyMu6iajuqNqSNZiIJhPJ8djsIZNIbvUoS3wZl2sEX7UBdtpeY4sOdAmr1x121ChqVzmxXaceeil2njSpYcOXcFlNhUQJVUrKnEyz2Nbz6hIA1Gw",
          "widthPx": 3024,
          "heightPx": 4032,
          "authorAttributions": [
            {
              "displayName": "Lachriss & Co",
              "uri": "https://maps.google.com/maps/contrib/107465359466068116706",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjV5J16FA9diEJBe1JnSObdUTczXjm2db7vUVqO2bx9tdCScXDK5=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgICD7M3LmgE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgICD7M3LmgE!2e10!4m2!3m1!1s0x47f29dcdf4a22b1b:0x63c214cda2cee5ee"
        },
        {
          "name": "places/ChIJGyui9M2d8kcR7uXOos0UwmM/photos/AcnlKN1ARlbDv2K2Te2SBO-ThAgLtn4Sbth-xt0ZXsW0aipFCIy2zaqf15qJhNOVYubuFsRpQvlLE12eI-Z9ZDUMYrkSuNQoOjDqGncSQYubSCQITRXgtsX9eVoU_DAQXdlWeUnA6A7TkAhJC7LYk8o-WOxrJ9k4Wwj0O7zLiTi1ZxYAbjS0sVsy1Ch0Id4fTNWrbFbLrs_oiXe9ecKX7xi17oSooDgwkkaXNupJSoE3ejDkoUghaIbTXURzVtGqQLqVtG9fHmhC2bEnvuZp50LkbliY93yRVcBqugJI3-oFvB4R9w",
          "widthPx": 2119,
          "heightPx": 1192,
          "authorAttributions": [
            {
              "displayName": "Pathé Dijon",
              "uri": "https://maps.google.com/maps/contrib/109409545014841352474",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVPrBy6XKp2oaHU2VERI0E9Gf0VZMqy438t4JsAw89rlyJ7ypbu=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipOJ_GPQsTt_5rV4hRZHtXKXKDl_XibW3yRcwr9v&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipOJ_GPQsTt_5rV4hRZHtXKXKDl_XibW3yRcwr9v!2e10!4m2!3m1!1s0x47f29dcdf4a22b1b:0x63c214cda2cee5ee"
        },
        {
          "name": "places/ChIJGyui9M2d8kcR7uXOos0UwmM/photos/AcnlKN1GixbrihUVvsrqxM7fjSdyjIcSVgw-U55kITq6KWqyXI32n-slVkM_j5jcnZnepXpe8x9EnmgO7WET15aAQ-4QNFI6MEfkncYa3UCD7gYlIQoAVD1_0QRXCOGOzPvQHjbQ96JVFrqwnbkbyPVuJ8aNX73R7twOdXCip2rIT1jdpldsOTTNmw_a7M-bcToNFUxv1BJB0Nxkyfn8j56QOE6kQz6nOGNmWGmypzcIeaoq5SDxqWuDzVJ4Kto_HsH4642zZIgRjPJISlVUhMCQqN9IeOOngAXhwOJlZQstUWdxsNmrxQHR2CYKDbUyMJRMOMijTZIedYM-v0zDi9bDyeK1Dq6yJrIVo9ZR6M4Xth-NPh-oAX7NwC6WMEOGk2HVPJgeMoBlPF04n7X7Sg3K1v7fbyv3PlvUfLruhT8iS04zDF4",
          "widthPx": 2160,
          "heightPx": 3840,
          "authorAttributions": [
            {
              "displayName": "Yann",
              "uri": "https://maps.google.com/maps/contrib/107584843976638934255",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWvWfH3ruBraaX7qUbBSwGjTWohYjAmKTVzynjAjrD7FoMe5CeR=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgICRk9if4AE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgICRk9if4AE!2e10!4m2!3m1!1s0x47f29dcdf4a22b1b:0x63c214cda2cee5ee"
        }
      ]
    },
    {
      "formattedAddress": "8 Pl. Saint Bénigne, 21000 Dijon, France",
      "rating": 4.4,
      "userRatingCount": 4646,
      "displayName": {
        "text": "Restaurant Gril'Laure",
        "languageCode": "fr"
      },
      "reviews": [
        {
          "name": "places/ChIJNeHH5uqd8kcRkXtdXhVJyy0/reviews/Ci9DQUlRQUNvZENodHljRjlvT2xaRVpGcEpNbGszZEZKRmJ6QjZla2hGY1VvMVoxRRAB",
          "relativePublishTimeDescription": "2 months ago",
          "rating": 2,
          "text": {
            "text": "Staff were absolutely incredible. Food missing the mark by far. Definitely edible. But for the price and what is described on the menu it misses the mark by far! If you’ve travelled Europe and had good food you will be disappointed by the food quality. Wine and kids menu was the best part of the night. Kids meals are €10. But €50 for a bottle of wine and €50 per adult for food we left disappointed. Overall, I would rate the experience good , but not anywhere near my expectations.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Staff were absolutely incredible. Food missing the mark by far. Definitely edible. But for the price and what is described on the menu it misses the mark by far! If you’ve travelled Europe and had good food you will be disappointed by the food quality. Wine and kids menu was the best part of the night. Kids meals are €10. But €50 for a bottle of wine and €50 per adult for food we left disappointed. Overall, I would rate the experience good , but not anywhere near my expectations.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Daniel Williams",
            "uri": "https://www.google.com/maps/contrib/100692939545759660438/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWRGBUJcGHkC_iMeNTjr2V80AFgXJ5GuiVefK1YBNXHoG2OuBofvQ=s128-c0x00000000-cc-rp-mo-ba5"
          },
          "publishTime": "2025-11-25T23:43:12.899875197Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2xaRVpGcEpNbGszZEZKRmJ6QjZla2hGY1VvMVoxRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2xaRVpGcEpNbGszZEZKRmJ6QjZla2hGY1VvMVoxRRAB!2m1!1s0x47f29deae6c7e135:0x2dcb49155e5d7b91",
          "visitDate": {
            "year": 2025,
            "month": 11
          }
        },
        {
          "name": "places/ChIJNeHH5uqd8kcRkXtdXhVJyy0/reviews/Ci9DQUlRQUNvZENodHljRjlvT21SVVQyaDRMVEJWVUhGNlNURldPVTlVZEdWdWIzYxAB",
          "relativePublishTimeDescription": "5 months ago",
          "rating": 4,
          "text": {
            "text": "Service was excellent. Really enjoyed the escargot and foie grass starters. The rib steak was excellent, and you could taste the wood it had been cooked over. Great wine selection as well, and a really good creme brulee. A couple of issues; the 3 x skewers (beef, duck and chicken) were cut inconsistently so most were overcooked and pretty tough, and the Thai style pasta dish had overcooked pasta and could have used a bit more Thai flavor. Still had a great evening, and recommend.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Service was excellent. Really enjoyed the escargot and foie grass starters. The rib steak was excellent, and you could taste the wood it had been cooked over. Great wine selection as well, and a really good creme brulee. A couple of issues; the 3 x skewers (beef, duck and chicken) were cut inconsistently so most were overcooked and pretty tough, and the Thai style pasta dish had overcooked pasta and could have used a bit more Thai flavor. Still had a great evening, and recommend.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "M.M. R.",
            "uri": "https://www.google.com/maps/contrib/106065492913705232035/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUw5QB1izWzZacXsj0KDYkdhaTok35CtECGSiy0TB8Oz1YimRCqmA=s128-c0x00000000-cc-rp-mo-ba4"
          },
          "publishTime": "2025-08-07T21:03:51.282168874Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT21SVVQyaDRMVEJWVUhGNlNURldPVTlVZEdWdWIzYxAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT21SVVQyaDRMVEJWVUhGNlNURldPVTlVZEdWdWIzYxAB!2m1!1s0x47f29deae6c7e135:0x2dcb49155e5d7b91",
          "visitDate": {
            "year": 2025,
            "month": 8
          }
        },
        {
          "name": "places/ChIJNeHH5uqd8kcRkXtdXhVJyy0/reviews/Ci9DQUlRQUNvZENodHljRjlvT21nMWEweDBPRWxIWmtkU05WTlNOM3BMTFY5U1JVRRAB",
          "relativePublishTimeDescription": "4 months ago",
          "rating": 5,
          "text": {
            "text": "We couldn’t have chosen a better place for our very first French meal in France than Le Restaurant Gril’Laure in Dijon. The long line of locals waiting outside was already a clear sign of how beloved this place is. We arrived just before noon, queued without a reservation, and were fortunate enough to be seated.\n\nA very special shoutout goes to Hanna, who made the entire experience exceptional. She was attentive without being intrusive, always checking on us regularly, ensuring we always had water, never rushing us to order, and offering helpful recommendations. Her warmth and professionalism elevated our first French dining experience into a memory we’ll never forget.\n\nThe food itself was simply outstanding, with portions more than generous. We enjoyed two formules du midi:\n•\tPizza Gril’Laure, hearty and delicious.\n•\tL’assiette bourguignonne, a wonderful sampler that brought together Dijon’s specialties in miniature form. Yes, there’s an escargot mini burger. They use firewood for the grilling and you can see it live.\n\nFor starters, we had escargots, a must-try in Burgundy. For dessert, the café gourmand (espresso with an array of miniature desserts) and fromage blanc were the perfect finish. To drink, we discovered the local Kir, a Dijon specialty of raspberry syrup flavoured wine.\n\nEvery dish was beautifully prepared and full of flavor. Combined with Hanna’s impeccable service, the experience was unforgettable.\n\n👉 Our advice: arrive by 11:45 if you don’t have a reservation. it’s worth the wait!\n\nÀ Hanna,\nNous te remercions énormément pour ton accueil et ta gentillesse. Merci d’avoir fait de notre premier repas à Dijon un très beau souvenir. 💐",
            "languageCode": "en"
          },
          "originalText": {
            "text": "We couldn’t have chosen a better place for our very first French meal in France than Le Restaurant Gril’Laure in Dijon. The long line of locals waiting outside was already a clear sign of how beloved this place is. We arrived just before noon, queued without a reservation, and were fortunate enough to be seated.\n\nA very special shoutout goes to Hanna, who made the entire experience exceptional. She was attentive without being intrusive, always checking on us regularly, ensuring we always had water, never rushing us to order, and offering helpful recommendations. Her warmth and professionalism elevated our first French dining experience into a memory we’ll never forget.\n\nThe food itself was simply outstanding, with portions more than generous. We enjoyed two formules du midi:\n•\tPizza Gril’Laure, hearty and delicious.\n•\tL’assiette bourguignonne, a wonderful sampler that brought together Dijon’s specialties in miniature form. Yes, there’s an escargot mini burger. They use firewood for the grilling and you can see it live.\n\nFor starters, we had escargots, a must-try in Burgundy. For dessert, the café gourmand (espresso with an array of miniature desserts) and fromage blanc were the perfect finish. To drink, we discovered the local Kir, a Dijon specialty of raspberry syrup flavoured wine.\n\nEvery dish was beautifully prepared and full of flavor. Combined with Hanna’s impeccable service, the experience was unforgettable.\n\n👉 Our advice: arrive by 11:45 if you don’t have a reservation. it’s worth the wait!\n\nÀ Hanna,\nNous te remercions énormément pour ton accueil et ta gentillesse. Merci d’avoir fait de notre premier repas à Dijon un très beau souvenir. 💐",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Gary Pan",
            "uri": "https://www.google.com/maps/contrib/113495714643289127322/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVtik6yI6ch37MSUdmmkR06kQUbYa68hHa_SiChOlgDQYYn9kn-PA=s128-c0x00000000-cc-rp-mo-ba4"
          },
          "publishTime": "2025-09-16T14:32:50.298391106Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT21nMWEweDBPRWxIWmtkU05WTlNOM3BMTFY5U1JVRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT21nMWEweDBPRWxIWmtkU05WTlNOM3BMTFY5U1JVRRAB!2m1!1s0x47f29deae6c7e135:0x2dcb49155e5d7b91",
          "visitDate": {
            "year": 2025,
            "month": 9
          }
        },
        {
          "name": "places/ChIJNeHH5uqd8kcRkXtdXhVJyy0/reviews/ChZDSUhNMG9nS0VPaVF3X3VreTRuSEZBEAE",
          "relativePublishTimeDescription": "8 months ago",
          "rating": 1,
          "text": {
            "text": "Disappointing Experience Overall\n\nUnfortunately, my recent visit to this restaurant was far from satisfactory. The quality of the food was notably poor—particularly the pizza and ravioli, which lacked flavor and freshness. The seafood linguine was also extremely disappointing, and the green gazpacho appeared to be off, raising concerns about food safety.\n\nI was hosting friends and wanted to introduce them to the area, which made the experience even more disheartening. What further diminished the evening was the service: the waiter was noticeably rude, unprofessional, and inattentive throughout our visit. His attitude and manner of serving the table did not reflect the standards one would expect from any dining establishment.\n\nRegrettably, this is an experience I will not forget—but for all the wrong reasons. I cannot recommend this restaurant based on this visit.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Disappointing Experience Overall\n\nUnfortunately, my recent visit to this restaurant was far from satisfactory. The quality of the food was notably poor—particularly the pizza and ravioli, which lacked flavor and freshness. The seafood linguine was also extremely disappointing, and the green gazpacho appeared to be off, raising concerns about food safety.\n\nI was hosting friends and wanted to introduce them to the area, which made the experience even more disheartening. What further diminished the evening was the service: the waiter was noticeably rude, unprofessional, and inattentive throughout our visit. His attitude and manner of serving the table did not reflect the standards one would expect from any dining establishment.\n\nRegrettably, this is an experience I will not forget—but for all the wrong reasons. I cannot recommend this restaurant based on this visit.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Chef Chabchoul",
            "uri": "https://www.google.com/maps/contrib/100850791282892514034/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjV8VO43DAK7yMWMCAxjDBSc7CmLSdK2PO3Np-JOlOj3t2i8rt-S=s128-c0x00000000-cc-rp-mo-ba5"
          },
          "publishTime": "2025-05-23T15:04:21.401832Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChZDSUhNMG9nS0VPaVF3X3VreTRuSEZBEAE&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChZDSUhNMG9nS0VPaVF3X3VreTRuSEZBEAE!2m1!1s0x47f29deae6c7e135:0x2dcb49155e5d7b91",
          "visitDate": {
            "year": 2025,
            "month": 5
          }
        },
        {
          "name": "places/ChIJNeHH5uqd8kcRkXtdXhVJyy0/reviews/ChRDSUhNMG9nS0VJQ0FnSURueFlCThAB",
          "relativePublishTimeDescription": "a year ago",
          "rating": 5,
          "text": {
            "text": "We were first time in Dijon, and happily advised to visit this restaurant. It is about grill and pizza. Foos was super tasty.\nThey have no menu in english and service was strange. They bring all the dishes simultaneously. But  overall it was fine.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "We were first time in Dijon, and happily advised to visit this restaurant. It is about grill and pizza. Foos was super tasty.\nThey have no menu in english and service was strange. They bring all the dishes simultaneously. But  overall it was fine.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Anar",
            "uri": "https://www.google.com/maps/contrib/113971962366497958438/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWOaQH0wbqnJkPNVtDg1eSKYXX3Bqe3EGARZ2U4AVE1fDmSD9KY=s128-c0x00000000-cc-rp-mo-ba4"
          },
          "publishTime": "2024-10-07T21:31:26.998850Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChRDSUhNMG9nS0VJQ0FnSURueFlCThAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChRDSUhNMG9nS0VJQ0FnSURueFlCThAB!2m1!1s0x47f29deae6c7e135:0x2dcb49155e5d7b91",
          "visitDate": {
            "year": 2024,
            "month": 10
          }
        }
      ],
      "photos": [
        {
          "name": "places/ChIJNeHH5uqd8kcRkXtdXhVJyy0/photos/AcnlKN0JZiDuLFabbAnIUmkG_QTzb5FxS_SqliygBS7sBQSdyQwIzn1rU809bBa5zc7Zi6lAesfYyN5rJK6AmRRbtSYYs3YkgKvjykFpPEAQeu-fI3ajDTvtTqLg9uR1yBRDUTPOVAC8pj5o3KKiQUnmQnbB01zbNttrHkMWCVVyuxY26TMbwU8RdMvt-4YzayR6Sve53zJZK4-7Lu286z3EfZmtrsZoTaY1tW2G0Iq4DQ8kLV-wPOZlWol5A6rqrev6aOYFZ4lHEDHCXAk7-WP8fc5Q15rTe38I45zdcRbH17Rlhw",
          "widthPx": 4800,
          "heightPx": 3200,
          "authorAttributions": [
            {
              "displayName": "Restaurant Gril'Laure",
              "uri": "https://maps.google.com/maps/contrib/108157012937238361566",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXXOeOJX-zjbYV9AbxLOwRFQmkp9iNSt1RtjTRK9og8GbhCZEDt=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipPG-jRf1gyM0-UNUbzxaHBs-OXyE-ocJJL7a-B9&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipPG-jRf1gyM0-UNUbzxaHBs-OXyE-ocJJL7a-B9!2e10!4m2!3m1!1s0x47f29deae6c7e135:0x2dcb49155e5d7b91"
        },
        {
          "name": "places/ChIJNeHH5uqd8kcRkXtdXhVJyy0/photos/AcnlKN2oCx3Bdy_ziqFQKqbTjo1mGY9qcLuZ-0BAvaOuqzz0cSKfpCLSikTWPgAk461VsnV8tlobonXrA4LpO2b0L7Jmb1ZqLcwGShh23HaC8M6ejiPDaz0SezMIt4zEzv2JxknJgKYQ93T_pmhV___uTS9xJqVl1zD_-2ca6pq9EaAA9mNsCCFWlrfcSdsIqPfY90Ds49dhBl91riX96CVmQRWiWqB8nqORL2viQEt0ZcPaBzBBmxQ4vMwLWBRuJFEGmDGbyR8gsbx0M_La6fwzc4_UOPbM29Pjs2XteV2667-X0A",
          "widthPx": 4200,
          "heightPx": 2800,
          "authorAttributions": [
            {
              "displayName": "Restaurant Gril'Laure",
              "uri": "https://maps.google.com/maps/contrib/108157012937238361566",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXXOeOJX-zjbYV9AbxLOwRFQmkp9iNSt1RtjTRK9og8GbhCZEDt=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipOzvE6oShpmR5RLwtSq7gbFDwuhAmEfl-9YrMHP&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipOzvE6oShpmR5RLwtSq7gbFDwuhAmEfl-9YrMHP!2e10!4m2!3m1!1s0x47f29deae6c7e135:0x2dcb49155e5d7b91"
        },
        {
          "name": "places/ChIJNeHH5uqd8kcRkXtdXhVJyy0/photos/AcnlKN3aIgf_OpA34Qd3pKgdySc1LWk4BBRKSRddokfew2pa29VvDT7EFzxBuiv8RMgxTQoJl1qVk68Fw3tFPBqI2XR-Dbq8h5N7V538ZWIs_6Yz75Ns2O6Wo6Fz8umu1rjuFyA2LYAZZLNULQMRQBV-EprrKWEAMRanDqZoR2EACFXnp0J9iRkw7fqWvdGhTf1fgSXOzGEakiunK4suJuJdGsYjmmBDIiLLL-ASyYHUnr1JnDjkNx-JVP0soImaF4aDjaWToIVTkvUB24Q1sYhZP09FmJ5FZGTkSG0POuF1sld5ICeYYFQgM2cwi4AQ0ElRBbgT0kDn9lImyK8VdMonTOz7jdm44SJdaITKLDuHGqjILbcIXuVHYxzvPcdiHIaaWfGARlsNLDjWWcuRwAjKTA_CpRd6NZwSQXeYhERbb8a-Ke4k0ClECsXMgz0iVW5X",
          "widthPx": 4000,
          "heightPx": 3000,
          "authorAttributions": [
            {
              "displayName": "M.M. R.",
              "uri": "https://maps.google.com/maps/contrib/106065492913705232035",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUw5QB1izWzZacXsj0KDYkdhaTok35CtECGSiy0TB8Oz1YimRCqmA=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhDKFUyZlxhgVBeuHMoA3xzQ&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhDKFUyZlxhgVBeuHMoA3xzQ!2e10!4m2!3m1!1s0x47f29deae6c7e135:0x2dcb49155e5d7b91"
        },
        {
          "name": "places/ChIJNeHH5uqd8kcRkXtdXhVJyy0/photos/AcnlKN0XC06afVhYeexR6Nq_mxytJV-qVmdXVmcQgMm3MgBhIXyfpWwGPgOK9Sx-NHk36LynmAJilAFK5AVykfbQXMk85BrI6frcdrCsrcoeCilpjuhMbKHy3YXf2sg8oobD2ttbxJij5EDrxANE-wdNuv-92lEV5VCrvuEuexYTUqXZyDnPerLQR19pzzGOO9uMAmzWgcehznZ4UUiBP74zZ1i8l-skSVwrl6U4EcPlc3Vc4XkWzTeStuj7u5rY14w9ZnbHT7OIsI84wzMt5USTvsqlIeLjE0ypi-kjUJPwcl6CQ2IOV6r9WaVf0_ZjFIcQacIPg0rf_sMxgDR-MNNPvA68xezvKaTaaUJEO3B54YIfafuiOO0j8-xRXrAe_QcTmQDi6uSPTRm1yoZnhgQYygRkkHmEvW3LDBvQTkAR2-c",
          "widthPx": 3024,
          "heightPx": 4032,
          "authorAttributions": [
            {
              "displayName": "Damien Vincenot",
              "uri": "https://maps.google.com/maps/contrib/106549123687763991770",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXgLM8cGJMshgBblf4GCpRCe9TLDoDKPH-7iEDbxS9Eg36Z_I_V=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEOeuqfu276qLdA&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEOeuqfu276qLdA!2e10!4m2!3m1!1s0x47f29deae6c7e135:0x2dcb49155e5d7b91"
        },
        {
          "name": "places/ChIJNeHH5uqd8kcRkXtdXhVJyy0/photos/AcnlKN29uWe1V-d-yubBT5KSSiRQO2tnBR-_7XzO_UH1bKmiE4sgIzWGWeu75jqv2K84vY_6Gb9seEgcTBV8p_dU7xZO17DG7TKhc-aWj3_TheZVErqSLnM9tYr2VMCc7Cxgm5Q8gaOJMkThDlvXXAidJD9PiO2gx53ttzBulVd50hzqA1-qjsXHs8FuPxol5Ynf0u9ayr8Z3WOigale-W9mMaKVwoOoGZ8K2A8HKUiNJyaaiDrXfV2-5YuiquozPq2BMCtsSinerMnYjUQbMZ9eW7FuR3l6w1BSHXk6VmD-u46aD1UniJB09QxUNBB3PjKV7xJujdotzcs1iXtTVSI3nTZr8ixpTSORjyaruRSXA1NqfAdolODBN27ajFARtJYofVerHsC7yb9Ogw4drOWDxIFhpMUYW-ARDddLA03fjr89BzVNDExlhMbsrEPPGA",
          "widthPx": 4032,
          "heightPx": 2268,
          "authorAttributions": [
            {
              "displayName": "Diego Torriani",
              "uri": "https://maps.google.com/maps/contrib/104869131526383121697",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjW86SFJB2idGBOBKk7U0a9BZREU-gm35qCEAxguk1vEQZXRAeG4=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhDiWdfE0N78eXAXzIV-G-lf&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhDiWdfE0N78eXAXzIV-G-lf!2e10!4m2!3m1!1s0x47f29deae6c7e135:0x2dcb49155e5d7b91"
        },
        {
          "name": "places/ChIJNeHH5uqd8kcRkXtdXhVJyy0/photos/AcnlKN2JuTRgJMmVGbTQa1TTujz6zcZrDM38HBluxgQGotkQFEQsZ8oaL-iAaMAqVBwasu1DGb95MroQU4so_Oo-En076GbqqhHPRKsc0_OcOwMBl0_cPaiDqnYl-TSb1rko2D1e0CYDVMF1-fFLmowlMV33pvh3RbQIhifeV7I65OE67YUP3lSWzfm6bPwtVGYHKjNAsEp5b7Ac5tMoExvqAx6uU0DS0oHiYo8-tiZiDim22i5HeV09aq1w72cFgaKIFqBTm9P94WUE7h2hQTbryjxwWEwzDCcGrSEEtf1n7mN6Zl8cJUpQP7frwXdfPjXt_rx3yi21AydLCgSSlLYjkhUizB4i6wVOefMNUmd_dgglLXpvrM07rbFKhOEZyrI9ULG_qK7i1lpY8ZRHfpi7ZbtN0xAQ8qZkHu5BHL8rukqAdzMXXroqTmYSiUqw5VBZ",
          "widthPx": 4800,
          "heightPx": 3600,
          "authorAttributions": [
            {
              "displayName": "Alexandre Mendez",
              "uri": "https://maps.google.com/maps/contrib/115675287188224492487",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocJsoUPrXSQgPSwj0zQpcQYVEOzfMmO8TPI8IA01HecBx3tjLA=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhAa251Ts6ouLm-CHvjmbKn3&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhAa251Ts6ouLm-CHvjmbKn3!2e10!4m2!3m1!1s0x47f29deae6c7e135:0x2dcb49155e5d7b91"
        },
        {
          "name": "places/ChIJNeHH5uqd8kcRkXtdXhVJyy0/photos/AcnlKN2lghegZVp6RcwDgeOfFekw9xtkhSLY1PwUdQ0uO8_yMjO1-V9V7E1hcja5xwW1OI0_rKChy0qTIKMogQ83u46TqfM5oyfVNJxTRhrM9xszQi-5qNY7XV6HBvYM74OEoo-U1m4fQCsEPcBti6_qp8ekgvbv0KLQMVA5wh6nAI-3EvCZQ_TJnXiuls5aydALGrSqtQXtVeoEzcK5pykoF8wgB5oZnkg4c76uwhWI8biDm28dky-MapBIhSd4lg9NyqdHwBGZqVsgydhhq0LHZddkiqgZWzydPKsmuPLh0X_Xb0Po1If31_Vd_YGD7FVXJhGGSL-28P4yRwZgDco4gsx8s8xwRnIwNk60zmIh9lD2IIAOR9qdkzgQX6b-qyR25smID4TRjTZTehSAHwgXPThP0V0d02R-1TdCm54o9pZGj1U79rSt7SWsKvKRvw",
          "widthPx": 3024,
          "heightPx": 4032,
          "authorAttributions": [
            {
              "displayName": "Philippe Serre",
              "uri": "https://maps.google.com/maps/contrib/107515998825953563723",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocJPGXwwYQ2PB4f998aaB5NiTOfNSQX46Ubms58NfuzifTNxTA=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhAjibF65F-e4dJ7kNMfp4r9&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhAjibF65F-e4dJ7kNMfp4r9!2e10!4m2!3m1!1s0x47f29deae6c7e135:0x2dcb49155e5d7b91"
        },
        {
          "name": "places/ChIJNeHH5uqd8kcRkXtdXhVJyy0/photos/AcnlKN23jqka0Qz2ssPOfOQshvo1f0usWhHTB3DuxJVfgM7RJOe8fEz22_fMuRy6ePJ2_RgVoSMTkScL9s6qPjdby0raScHWZvcXBHBkpgXPLEGmjYCRgnfW1CIeXUuQKu7McBx3kZeftP2sD_c_DynunRzCca7MV3f0V-wWxo0aSN0rwP0DprhbRACgdflHBDtI4kAHePzzrDI9CeV6xooGH8wfi4pfvWtGXMo5hnY4klMmE9qV0rRkoTT2TrCf0muUcIkagKgWqJWVNtOjSxOU1rnYU-aTwH60AwLN9GDt8t0oga6HPupsSkIMbEEbniar8s_Y8V_uo6MiI8GPwxoHLloHOJZkyMWD6ILrx0ugGeMG4s0Mawo1maC-lEgn_UaNyU8UILePvbKLPRpRQX_LG-wWOZi6RuPOhfYsOJKW2O-LMJWP",
          "widthPx": 4032,
          "heightPx": 3024,
          "authorAttributions": [
            {
              "displayName": "Alejandro Pereira",
              "uri": "https://maps.google.com/maps/contrib/106171081478737868963",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUOEBMg0umjemZKB5CcEm21Q7noxlEqzxcs5Z56ahooRMQO-_hx=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgICLvcX41gE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgICLvcX41gE!2e10!4m2!3m1!1s0x47f29deae6c7e135:0x2dcb49155e5d7b91"
        },
        {
          "name": "places/ChIJNeHH5uqd8kcRkXtdXhVJyy0/photos/AcnlKN2LjkOorca3CkQOt89QXoeBmCnjdqB3EP69OJ_Q5j9VLjFrAULTDMATbpYuEMGXMDZz8XXTKp-GSk2gL-6tipAFEu-Fx1_3Vo9NJmAJRYpSwGBUq0D5ncxw2n2TP1vY3Q5Z_0jQu5GG1WEW5pVCMS9maZ-X-P_WXPDXnfwfU5Y-Kdpaf_A9gMrLoYUtQecLWnO5zKIprRTuqKt-ArW7zjVssviZoebol2ZJ_TBSgXFtUVAlsrQhnIvFDETgnwkVApPu1cqN1RP_wwX5tWjnyUJ_yDRlSuA7knnzn3TQENF-rBzZcVUGi9CRML4HZNpjtPD4KkiSJUFxbj4stHrr0G9n23SqJEB4tBHqI1CNQNcP7P5_1NKX5h6dxQVj3QL8wSKDn-NsAlpI57rN2dkvjUL6MYD9i8KEdZyNLW6wQ8HItP5f3tbwOF95YQEUdSkj",
          "widthPx": 3024,
          "heightPx": 4032,
          "authorAttributions": [
            {
              "displayName": "Alice Pottier Bergamaschi",
              "uri": "https://maps.google.com/maps/contrib/106589235801160107517",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUBu6P7D_UTwWK06pSd7GPuftyoxK6ULayPpCinGN_p1WaI4tFK=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhBiAyFm7Hxb4flJw8BIEjYq&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhBiAyFm7Hxb4flJw8BIEjYq!2e10!4m2!3m1!1s0x47f29deae6c7e135:0x2dcb49155e5d7b91"
        },
        {
          "name": "places/ChIJNeHH5uqd8kcRkXtdXhVJyy0/photos/AcnlKN3CosYbI8lrwCWLnylZkUAI2cCM92YVsq5AYCo8_MHpAxyjuvwZxvlRZ9omQPsuObtj3Q4BobhS-EHJGX-XfpXYyJm58BK9R5g9Rq5lzaEwkSMOU-huOzpOPgmJnonsfsVGal2gu7OWtaa7NqoVe6xcvO0lYyC3ha8zm0t9AfA4-N7CFB3zj3m0C_3IGTTDyjQ95cZ3Z6c_LAypTO7dIyAodP_IWdeOIBAxSrJeNuXRgnrDaMw8GahTI9GV_CZ4U_dinuV-lwMxYFa1uuVMI24-YhMW0Zd8IlnvGqkjc-WuM_L-XU_1RL0u4jSEI2C-MiqZ47YQoYWamxVl12f6GSRkN_R7YuSZYo5cX1XeMAx3--mi-xpe7Jb_wRYTTP-n66JsjRXhmlVlJ41a9iuw-uPd1zsiZEBE8KUCRkTvQ1Xyt1N9QfgZtCv1Dl8XR9hf",
          "widthPx": 4096,
          "heightPx": 3072,
          "authorAttributions": [
            {
              "displayName": "audrey eschemann",
              "uri": "https://maps.google.com/maps/contrib/109365581158764484801",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUjEBhC4ZH-THZFyDJZHmAI1RX4ZaGoCwjaXgEKsfrotncXvgBePg=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhD_4WxeCn065OLGQZrrFETA&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhD_4WxeCn065OLGQZrrFETA!2e10!4m2!3m1!1s0x47f29deae6c7e135:0x2dcb49155e5d7b91"
        }
      ]
    },
    {
      "formattedAddress": "8 Pl. du Théâtre, 21000 Dijon, France",
      "rating": 4.3,
      "userRatingCount": 1764,
      "displayName": {
        "text": "La Brasserie des Loges",
        "languageCode": "en"
      },
      "reviews": [
        {
          "name": "places/ChIJCYzDYuid8kcRnxkHTzRVDFs/reviews/Ci9DQUlRQUNvZENodHljRjlvT2taTVJYcHRlblZaWnpWak5FOHhTalZyV0Rkb1pYYxAB",
          "relativePublishTimeDescription": "2 months ago",
          "rating": 5,
          "text": {
            "text": "We arrived here quite by chance, and it turned out to be the best meal of our trip in Dijon.\n\nJoue de bœuf bourguignon was super flavourful, well-balanced, and really comforting.œuf meurette was also great. And the red wine we randomly picked (Mercurey 1er Cru 2020) paired perfectly with everything.\n\nIf you’re in the mood for good, traditional French food, this place is definitely worth a stop.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "We arrived here quite by chance, and it turned out to be the best meal of our trip in Dijon.\n\nJoue de bœuf bourguignon was super flavourful, well-balanced, and really comforting.œuf meurette was also great. And the red wine we randomly picked (Mercurey 1er Cru 2020) paired perfectly with everything.\n\nIf you’re in the mood for good, traditional French food, this place is definitely worth a stop.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Cinny Tsai",
            "uri": "https://www.google.com/maps/contrib/103961782326751422495/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUXICLmfIvwVPn9v-h1tL15ykRBnKoWtqgPMTW9DksaG8eQAnDe=s128-c0x00000000-cc-rp-mo-ba2"
          },
          "publishTime": "2025-11-23T17:46:01.564796722Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2taTVJYcHRlblZaWnpWak5FOHhTalZyV0Rkb1pYYxAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2taTVJYcHRlblZaWnpWak5FOHhTalZyV0Rkb1pYYxAB!2m1!1s0x47f29de862c38c09:0x5b0c55344f07199f",
          "visitDate": {
            "year": 2025,
            "month": 11
          }
        },
        {
          "name": "places/ChIJCYzDYuid8kcRnxkHTzRVDFs/reviews/Ci9DQUlRQUNvZENodHljRjlvT2tGbVZXUlhSbGgxZEcxWE1UTm9Ua2RqU25rNFlWRRAB",
          "relativePublishTimeDescription": "5 months ago",
          "rating": 5,
          "text": {
            "text": "Just for the location of this restaurant, next to the magnificent building of the \"Grand Théâtre\" and opposite the churches of \"Saint Stephen's\" and \"Saint Michael's\", it is worth visiting to absorb the beauty of the space on the \"place du Théâtre\".\nThe food was excellent! Especially the \"Joue de boeuf à la Bourguignonne\" was delicious. Also, the \"Croustillant de Chèvre Chaud\" had a special and distinct taste, which is worth trying.\nFinally, do not miss the wonderful wine \"Pinot Noir Bourg\".",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Just for the location of this restaurant, next to the magnificent building of the \"Grand Théâtre\" and opposite the churches of \"Saint Stephen's\" and \"Saint Michael's\", it is worth visiting to absorb the beauty of the space on the \"place du Théâtre\".\nThe food was excellent! Especially the \"Joue de boeuf à la Bourguignonne\" was delicious. Also, the \"Croustillant de Chèvre Chaud\" had a special and distinct taste, which is worth trying.\nFinally, do not miss the wonderful wine \"Pinot Noir Bourg\".",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Grigorios Soumis",
            "uri": "https://www.google.com/maps/contrib/106905976564751068565/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUhh4qXUOwCTIeyYnYHMfov3fbjuik6qF0zs4U9sm4WEC4m0fVg=s128-c0x00000000-cc-rp-mo-ba4"
          },
          "publishTime": "2025-08-29T11:08:49.628559390Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2tGbVZXUlhSbGgxZEcxWE1UTm9Ua2RqU25rNFlWRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2tGbVZXUlhSbGgxZEcxWE1UTm9Ua2RqU25rNFlWRRAB!2m1!1s0x47f29de862c38c09:0x5b0c55344f07199f",
          "visitDate": {
            "year": 2025,
            "month": 8
          }
        },
        {
          "name": "places/ChIJCYzDYuid8kcRnxkHTzRVDFs/reviews/Ci9DQUlRQUNvZENodHljRjlvT2t0aGMwMDRaa1pQTVZJeU5IcG1ZMWR4TmxKSGMyYxAB",
          "relativePublishTimeDescription": "6 months ago",
          "rating": 5,
          "text": {
            "text": "The food was really good, unexpectedly. We just googled it and went to eat as we had just arrived and the kids were famished from a long drive. The snails were really good and I lived the braised beef. Vibe was casual, lots of families and couples.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "The food was really good, unexpectedly. We just googled it and went to eat as we had just arrived and the kids were famished from a long drive. The snails were really good and I lived the braised beef. Vibe was casual, lots of families and couples.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Taehee Kim",
            "uri": "https://www.google.com/maps/contrib/113052435818869232848/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjX82jDMXPqVmhzT2DmIY9i68oxr1dU21ZXF1fUJOCRs_yCaThG8=s128-c0x00000000-cc-rp-mo-ba5"
          },
          "publishTime": "2025-07-20T20:44:44.498933027Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2t0aGMwMDRaa1pQTVZJeU5IcG1ZMWR4TmxKSGMyYxAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2t0aGMwMDRaa1pQTVZJeU5IcG1ZMWR4TmxKSGMyYxAB!2m1!1s0x47f29de862c38c09:0x5b0c55344f07199f",
          "visitDate": {
            "year": 2025,
            "month": 7
          }
        },
        {
          "name": "places/ChIJCYzDYuid8kcRnxkHTzRVDFs/reviews/ChdDSUhNMG9nS0VJQ0FnTUNnLXZ1b2d3RRAB",
          "relativePublishTimeDescription": "11 months ago",
          "rating": 5,
          "text": {
            "text": "Friendly staff who speaks English. The restaurant has 2 floors, so it can accommodate big groups. Still, it’s a busy place, so make sure you make a reservation on Sundays.\nFood was nice. Not too salty like many other restaurants we tried. We enjoyed the beef Bourgogne, as well as the andouillette de Jargeau. Food came fast.\nVery good value for money.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Friendly staff who speaks English. The restaurant has 2 floors, so it can accommodate big groups. Still, it’s a busy place, so make sure you make a reservation on Sundays.\nFood was nice. Not too salty like many other restaurants we tried. We enjoyed the beef Bourgogne, as well as the andouillette de Jargeau. Food came fast.\nVery good value for money.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Priscilla Young",
            "uri": "https://www.google.com/maps/contrib/100516884596120861170/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjX0RgWBhy1QdmdsmJcacIKSpDYyOn9OOFMfsi3_zK8OLOmk4SFG=s128-c0x00000000-cc-rp-mo"
          },
          "publishTime": "2025-02-16T13:21:05.265191Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChdDSUhNMG9nS0VJQ0FnTUNnLXZ1b2d3RRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChdDSUhNMG9nS0VJQ0FnTUNnLXZ1b2d3RRAB!2m1!1s0x47f29de862c38c09:0x5b0c55344f07199f",
          "visitDate": {
            "year": 2025,
            "month": 2
          }
        },
        {
          "name": "places/ChIJCYzDYuid8kcRnxkHTzRVDFs/reviews/Ci9DQUlRQUNvZENodHljRjlvT2xORU9VUk5ObXhKYXpCeVVVNDRVMWh3TFd0Q05YYxAB",
          "relativePublishTimeDescription": "5 months ago",
          "rating": 5,
          "text": {
            "text": "Good food (great escargot!!), we order the menu for adults and the one for kids. Make sure you make a reservation to get good tables and not wait too long. Nixe location and view, I recommend this restaurant!",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Good food (great escargot!!), we order the menu for adults and the one for kids. Make sure you make a reservation to get good tables and not wait too long. Nixe location and view, I recommend this restaurant!",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Maria Paz Vallejos",
            "uri": "https://www.google.com/maps/contrib/101454592249937000133/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWnw1VKRbY8jfJURJOECFWBxABLXHM7OsQVFT7FTqUfyBLDcqBN=s128-c0x00000000-cc-rp-mo-ba2"
          },
          "publishTime": "2025-08-17T14:19:02.621276757Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2xORU9VUk5ObXhKYXpCeVVVNDRVMWh3TFd0Q05YYxAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2xORU9VUk5ObXhKYXpCeVVVNDRVMWh3TFd0Q05YYxAB!2m1!1s0x47f29de862c38c09:0x5b0c55344f07199f",
          "visitDate": {
            "year": 2025,
            "month": 8
          }
        }
      ],
      "photos": [
        {
          "name": "places/ChIJCYzDYuid8kcRnxkHTzRVDFs/photos/AcnlKN3sUXgcr8ZgaTnw8p4KaQXIPIuHewCT7HBtdcv7PgmXDzyw8X_s__Qb0CphNyYkYt1oNe51obwfn5MTPu0J3DGK-kDJ1xvBVSQJF7pfw0BVxZJOiJ2xaJG9DStGW91TGgLRX_gAxZFLfMt5g7Ghzy8EVGxZhN5foOGQkYhxvdyAM8d5EB-bvRUnqFw8vXJ5jwRHptoWkRfGkA54CR2pxWxxfkdPeEc71W2hew0HAxuvATAfv3QNAUpx99kas52rF8Yo0SJqHTnSsS3oQ37pYrbp2XiAkdF6zjaBX0eiDWopkw",
          "widthPx": 742,
          "heightPx": 497,
          "authorAttributions": [
            {
              "displayName": "La Brasserie des Loges",
              "uri": "https://maps.google.com/maps/contrib/104236830324584219646",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWL6tLTW2uild2lF2rjhYSfbG2I43AQNQpEVWM6kIILc0N47eNj=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipNRIRH3DQwUA74v8x0xpP93A8zSt5J4fT36-m3U&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipNRIRH3DQwUA74v8x0xpP93A8zSt5J4fT36-m3U!2e10!4m2!3m1!1s0x47f29de862c38c09:0x5b0c55344f07199f"
        },
        {
          "name": "places/ChIJCYzDYuid8kcRnxkHTzRVDFs/photos/AcnlKN1i4rd9KLAKEPgboTxK4sJlcgyt32AH53GH-Uuda9QJMPrUrd2OydTZDxYJCFC7FFehsNjXtzXygYTgx2VuE8nSk48CJ0kqzE9PJACsDCH13vFFWQWhQOsVxYNkHdWBRR3HiaKOGe1AxqBQFHSsfV6u41GJamUNTjx0JxMRRvGe_t1z19uGtcjx8KaO2UfYn7cA2EUw8nfYKbDmaWgWQD9HsE_ULvVqgmCZaEHkYw2Ij2YtYwfiwqrpvZdlTNBvT1y0LmMO18rD5vriINTG0Dhl7Icg1EoAyQVbUzcRpW_15g",
          "widthPx": 2764,
          "heightPx": 3686,
          "authorAttributions": [
            {
              "displayName": "La Brasserie des Loges",
              "uri": "https://maps.google.com/maps/contrib/104236830324584219646",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWL6tLTW2uild2lF2rjhYSfbG2I43AQNQpEVWM6kIILc0N47eNj=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipMdm4fqUZ0qplYpcG_ltyitrBAB02pJQkFVs95H&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipMdm4fqUZ0qplYpcG_ltyitrBAB02pJQkFVs95H!2e10!4m2!3m1!1s0x47f29de862c38c09:0x5b0c55344f07199f"
        },
        {
          "name": "places/ChIJCYzDYuid8kcRnxkHTzRVDFs/photos/AcnlKN2hFitqQP2wXfAX_0GJGRDA_XcOxNmhztrzra9kSwOr5iAw1ybSn6Dt4BdVyqpRQLNbw_r0huWmHveBNvcQecfKucNbBndF4qyuIS6USkwq2oqUvEoK8NtOzeGBxyhpVkztskWOxU5-s6jIfZGI5iJJHejj-j6jO219svPe-q0gxa0DnTVhz4CjKnF6wOFS6myM0nhmF46-3pSxyBZG1_n7iq8nSeC9GrfcYDVKsk0K_UDPpJc9td1yM0GZ5CHMt_GOXzIY_NFynNM2LymPYw79vKPvzLkSEW5vmf3RbUoynoGt6BaT8g68nWtUJUk70qsvsdwKTljhvV809s5UgD2ZKyhSCAsL924fY_qzhJAeHPMGbrgI5GTR42ZEEJEp8t8RFqR8kcIsx1-31HDogV3jOJ8cpj3CXTe_r0GNbZ9Kld9HC60yEbKTh5I4R0zh",
          "widthPx": 3600,
          "heightPx": 4800,
          "authorAttributions": [
            {
              "displayName": "J vS-25",
              "uri": "https://maps.google.com/maps/contrib/101118803968854359526",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocJ8MHskP77AbgZVZPAs95lnELjNoyqAjEqMely1Z5cSvLuS8Q=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhBJzBatS93_jXuPvZFk2qEF&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhBJzBatS93_jXuPvZFk2qEF!2e10!4m2!3m1!1s0x47f29de862c38c09:0x5b0c55344f07199f"
        },
        {
          "name": "places/ChIJCYzDYuid8kcRnxkHTzRVDFs/photos/AcnlKN3ZZ89qoeswcVBfKQ-VAc2hjJyY7C8zZ5ZxnMt8TP6BZdH-7CXCq0jQC9I1C4h-IT6J0rp-vrjh_HJWB_zfCwQ7Yziq50OXtkGfI8N2BgyV90pe34gDmhObsR9_JkpZ6TAQ5QC4eupnfHCeFwRPi0OcI4XBvFQrneWNed-AUNHoBsjsZSd0Hd57Rz6oQ-D6MY1lyUZa01R3LMkoyIwSiq46vTmCbG-_kFdbagn8bH_3HJVG6fxwArgh-9whrL5Khh2Pw5y5brdIhS8T9upk8bOVpYui98sFaNp0UI8SY7aTaFN8DbYeh_DvcFvhkXHaEV30b1Us2ho1AYWaRs2Z9PDCbXsJs0rDw0yE-bTclAZEMhyObJYb36X_rfy2VKtmmPM_Tt8SVnNEJOD-l19SQ0mYaS3wNAuht9b5Xng7WmOj3NyFrhD4eimYef7n4IyQ",
          "widthPx": 3600,
          "heightPx": 4800,
          "authorAttributions": [
            {
              "displayName": "Zanete Soeby",
              "uri": "https://maps.google.com/maps/contrib/105416576642182715564",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocLQ6xdTuSkfIcKC2Y9dDlkX1Yqfy3f2ZcncY9n6k4PApQfzlA=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhDdM6b_t6oUVKNYvzxmTa_L&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhDdM6b_t6oUVKNYvzxmTa_L!2e10!4m2!3m1!1s0x47f29de862c38c09:0x5b0c55344f07199f"
        },
        {
          "name": "places/ChIJCYzDYuid8kcRnxkHTzRVDFs/photos/AcnlKN3sL3-8deiBZVYdCFBCQc_EDLwXSY3jqwtwobOywb8wQNXAjyZBB4_szA2MQ65Q5pNyFB3HIsccVvwEPVcvFKoVOiJRqIoHXvAW4oYeQU58n2bNY5BLk1CvkxmoDtIhvyISlpr_EITntLZOnMQ7ARFrKo4gYwikoGPZg1202agdvXUDMruAQkD_B096y02EmrhOd738Ui4i8EG1DZWzT4qkxNKBH17r_WLKPgclvWr46N8X8z9vY-qPov54HKdQUcHHJUbxy0YiiSb27wtMuflR3SXiTLn971le1smzJUkZK0G0wCRRcN5g7FGGfeAXVw9veUvyvq6zV9uzLpa1MorXw6QoFVoC72V0646ddigMht25PyrbI3Lb77_nsaLgaEu7MkzPhsPF1qI4SnIAQzuruQzxp1nHLlLJ1K4qJlxSoE_w",
          "widthPx": 4032,
          "heightPx": 3024,
          "authorAttributions": [
            {
              "displayName": "Bruno ROYER",
              "uri": "https://maps.google.com/maps/contrib/109392309449432409417",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjX-lqY_OYgVombEZfkdPbOF0jj3YE2u6DKXAHHPQTp1PCm1kARr=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEIj5s_SI5IiGgAE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEIj5s_SI5IiGgAE!2e10!4m2!3m1!1s0x47f29de862c38c09:0x5b0c55344f07199f"
        },
        {
          "name": "places/ChIJCYzDYuid8kcRnxkHTzRVDFs/photos/AcnlKN16YOIYYwcsp2J1BGWJmPT7BgyF7VjNp4VG8FlnEWztBbgvnJnrRSrvZEFpG1vFqYRrZVSasYpO1YEPshUahPsrZAjbh8ZUdHatySk8ShrDoQnWdnKUU_ggpnEtv51FSyHaIa2QTyvqlOGro_MCC-WtgjbI58dK77G8U1BrJRGckS9MpB5Haa9oEAeEzfUG-is6hOcfXcNKfbsKBRF9DGWu1DUFS0TNqwtKvbtVUBkvn3KBdgwVXaNloDKaA39QDFQvalaA0nBzFQoKvkMsh-ldaPrEGi9O4Nra-FETMzb972qV3TLeK5nIdmAMb14youSPmjlO02EDmIvlv2jSzSLooPC30vgu62i9t8JXZjU_4MgNoAZAZPEnC2Sxkk3mayGyhjSizgwpWlYOtfZeKfLtWFV16LjwhCqafLMLyLVRo4RFt7GtYvzjriL4fW7E",
          "widthPx": 4080,
          "heightPx": 3072,
          "authorAttributions": [
            {
              "displayName": "Confit De Canard",
              "uri": "https://maps.google.com/maps/contrib/112833784333593728915",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVG-HtYTBoFNoXQtr-C__m3CemUfezZpZxIOeMh3LzBZH0E-TE=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhADycKzkCXwvmgDl18ADQmH&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhADycKzkCXwvmgDl18ADQmH!2e10!4m2!3m1!1s0x47f29de862c38c09:0x5b0c55344f07199f"
        },
        {
          "name": "places/ChIJCYzDYuid8kcRnxkHTzRVDFs/photos/AcnlKN0rYpGd1386kNgewRwXJ6wMjMjOczqbrup7idBn07lnPhZyvalAtTV6Jo7OnY_WBIUp-XJBuf_0Latk792DMuSdzIq1Vtpwnct1ufX8yCqUJNp9ZstPelRKx1lOpnQ8WZASCyXEvct29CbF1DB1VTuWLTdVD54qmtGyG1EYmWwp5phIcr_AjFYqHYjiZH-3xZgwgfpN9ciH3C7O8NJM6KNkVpQLzdieCoZyhSqe1jo676tjAd3YXRdwtGzVhVp8NQ8Lzka2rxIzA_M5mK3TmQFhyW83IKM1KGdfKPohz164pWnssGIHtKEGwkSyCJ6W9TcVMoIPiQSYPCbjfM6L3nQyVLtDcfkJzEVOzMM56cefkJTXDGWiVDHkL7iq4_r1QWkp2Hn9sFBiMNRJ4jRULL9NSotF3DTvEwZlGiM1tRd66x82lWT3UXVsFXA0pA",
          "widthPx": 4080,
          "heightPx": 3060,
          "authorAttributions": [
            {
              "displayName": "Stefano Tresso",
              "uri": "https://maps.google.com/maps/contrib/109140669465742815143",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocIMTj_Luh4VfkoD3Q7TNyxjfiqjw1VTXo9Ca_ILdUf2UCXI5w=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhBFZkcAlqkmJYNgmnVDYkX_&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhBFZkcAlqkmJYNgmnVDYkX_!2e10!4m2!3m1!1s0x47f29de862c38c09:0x5b0c55344f07199f"
        },
        {
          "name": "places/ChIJCYzDYuid8kcRnxkHTzRVDFs/photos/AcnlKN38uz1lJ-kOO25e_VP7iiFgIEmqdAxLYN-dBo6eG-0P5ZlVBeGUffN5RE0uP0RrxtIilU3eUDLy-sBNLA0hVYaNAnZeybm1qC2QJXs4OuC7-rktEYABsv_FFyh-iA8_srZjVyf3sVYW6RBSf9jPXWfvLVg9GHF0sD22sTnCLTiaN0Qe6-doXBlDMLf-Iu3sBQs1WiJtYv9ahCzd2Jfc202lRRiQFkiBwaNWUcrf0n7ns7dGK_H3ZBXy0NIiQYy_ov5SGbctypy-O4Le5UyHo6XVcgfPVf0Q65IY4-bnsejtxDIaNjIAb-Vgqpnb_7uazRd8CFgF0-HkaXxi8-qwvy3cf8GGHuolE4SmejCsNjXYtfzQgl-jELOGSRkdXPEBUpz2t-ivbuVQ9iK4PtMdqUXJtxp0sakr2RbVFERh5Xf1dA",
          "widthPx": 4032,
          "heightPx": 2268,
          "authorAttributions": [
            {
              "displayName": "FRED LEMAN",
              "uri": "https://maps.google.com/maps/contrib/109652538056062399251",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXwjCdsAUaw63ZadyyJa5bx2YVUxSv_HVXQ1O4Mm0dTYfkRjqk2UQ=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKELadypadgpTrXw&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKELadypadgpTrXw!2e10!4m2!3m1!1s0x47f29de862c38c09:0x5b0c55344f07199f"
        },
        {
          "name": "places/ChIJCYzDYuid8kcRnxkHTzRVDFs/photos/AcnlKN1a9cQ3erXcoydovDLSA7bTvpvx8BYwKs7cMfTaF_4Wg7JA0uW1ww4wdI36uF5pOtYuxrqDTG0EZrqiRa_e05ikQfkStozqbt0Hb7jb2rs-ogKaIU0lDNCFRKTI5XIMexeqBG4gnEgB_tXPu2bzzzgNwWOGyI_TanBMZ7UtbE0KlASjOcEUV-MpGnf6_dgNIQnyoUTfBzr9KCy6E2ALCfmftQU5LVCqIH4uELi_8JG8qEuqGmztRQ9pVONvRu7OwURnWRYMx1xK05PeRmbQuZBfb_0SpSvOgiCx15sQEtaNI-LveJR1c6JZDvhjk3fM8wDP5mfRou39WmVJXIfBvkRdNFBSVO3i4ZLxMhawPiecgJNmgrs7O4_08UwpdzNBn9yF3rlqEmzotfq89NVQQuHADT6nGnKKk2QED3iQhXz3-Q",
          "widthPx": 4032,
          "heightPx": 3024,
          "authorAttributions": [
            {
              "displayName": "Bruno ROYER",
              "uri": "https://maps.google.com/maps/contrib/109392309449432409417",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjX-lqY_OYgVombEZfkdPbOF0jj3YE2u6DKXAHHPQTp1PCm1kARr=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEL710rah2NXaCw&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEL710rah2NXaCw!2e10!4m2!3m1!1s0x47f29de862c38c09:0x5b0c55344f07199f"
        },
        {
          "name": "places/ChIJCYzDYuid8kcRnxkHTzRVDFs/photos/AcnlKN2uxILcYJHhtnUXTCiNPFgyvMVbJTjaMqKiowIUoNOCr7of96kgVW9kBmm0GCfKk0ckbwOwHhxcHB6o-wj1bkFrCfX6PYm_xQYUp18KpYb9ZtLd4QN6fwEfazmQVokrmSG3H87hFfBYswv_BaectKlTgSMRmxQSxcUsQ10old5QlmDRz6NFEELcBOWW4wlVKOTgShDBO9g3r8isQqrLW5JdMGPc16vctdDB8qMAoxJpFxOtn73ct6APRXdtAG-scdaPXKF4Ma5YnPOw-4hj2FrlLdGW-5qSV-GymKF7e5HIIh8GInkzjo3XLtvwVU6cGcSUeL96yjcBZ_7Ui7MYSjgO9hJFDrZKsHWYBfnnFf7kg-kV9shgYhE3HZHqDC_knrx5KAUGMRqkOA2VdyHiJlZyl1_swbswHzjezbVrtwL8sLnGYa8hloig_9zU9Fa9",
          "widthPx": 3024,
          "heightPx": 4032,
          "authorAttributions": [
            {
              "displayName": "Charlie Williams-Ellis",
              "uri": "https://maps.google.com/maps/contrib/106180336383194832360",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocLHXqbDgEqNdx0pG_s78RSOEJHE14OQ6pxX78aNmed_6wyMGw=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhACXwMTXl8oGISwjS2VVEpA&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhACXwMTXl8oGISwjS2VVEpA!2e10!4m2!3m1!1s0x47f29de862c38c09:0x5b0c55344f07199f"
        }
      ]
    },
    {
      "formattedAddress": "16 bis Rue Quentin, 21000 Dijon, France",
      "rating": 4.3,
      "userRatingCount": 3641,
      "displayName": {
        "text": "Les Fils à Maman Dijon",
        "languageCode": "fr"
      },
      "reviews": [
        {
          "name": "places/ChIJeenqwOmd8kcRI-Y9NfY-nic/reviews/Ci9DQUlRQUNvZENodHljRjlvT20xVVkzSmtSVUZFVFUwNVgyUlJVM2R2VVVsdVNtYxAB",
          "relativePublishTimeDescription": "a month ago",
          "rating": 3,
          "text": {
            "text": "Nice interiors and attentive service. Friendly people. Food could be better in my opinion. The croque-madame was ok but the bread was shoggy and not crispy. Also the butternut soup we had was dry and not creamy at all... The burger was good. Drinks were nice. Nice place overall, but food needs some attention.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Nice interiors and attentive service. Friendly people. Food could be better in my opinion. The croque-madame was ok but the bread was shoggy and not crispy. Also the butternut soup we had was dry and not creamy at all... The burger was good. Drinks were nice. Nice place overall, but food needs some attention.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Yiannis Evagelou",
            "uri": "https://www.google.com/maps/contrib/100624231646167859236/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWHMA7ps1v1KRS9mIgPbeSl-yf70GwxsiTK9GIDp96daqFHu52Zow=s128-c0x00000000-cc-rp-mo-ba3"
          },
          "publishTime": "2026-01-02T20:29:22.285719243Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT20xVVkzSmtSVUZFVFUwNVgyUlJVM2R2VVVsdVNtYxAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT20xVVkzSmtSVUZFVFUwNVgyUlJVM2R2VVVsdVNtYxAB!2m1!1s0x47f29de9c0eae979:0x279e3ef6353de623",
          "visitDate": {
            "year": 2026,
            "month": 1
          }
        },
        {
          "name": "places/ChIJeenqwOmd8kcRI-Y9NfY-nic/reviews/Ci9DQUlRQUNvZENodHljRjlvT20wMmVrSXpOMU5FUVZGcmJIZ3pNemRIVjA1YWQzYxAB",
          "relativePublishTimeDescription": "6 months ago",
          "rating": 3,
          "text": {
            "text": "The food came out cold even the fries. When we asked for hotter fries it's almost like they warmed up cold fries- wasn't crispy at all.\nThe service was slow- wr had to ask for water few times until one of us went to grab the water at the bar.\nThe atmosphere was nice though(inside) even though we sat outside.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "The food came out cold even the fries. When we asked for hotter fries it's almost like they warmed up cold fries- wasn't crispy at all.\nThe service was slow- wr had to ask for water few times until one of us went to grab the water at the bar.\nThe atmosphere was nice though(inside) even though we sat outside.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Naomi Demay",
            "uri": "https://www.google.com/maps/contrib/103958679178580820058/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjV8MAdnSeBQnVG7ps6x0lgxLPnMzIY5YMjp7lrTLreN47ksXzaa7g=s128-c0x00000000-cc-rp-mo-ba3"
          },
          "publishTime": "2025-07-22T12:15:53.385178937Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT20wMmVrSXpOMU5FUVZGcmJIZ3pNemRIVjA1YWQzYxAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT20wMmVrSXpOMU5FUVZGcmJIZ3pNemRIVjA1YWQzYxAB!2m1!1s0x47f29de9c0eae979:0x279e3ef6353de623",
          "visitDate": {
            "year": 2025,
            "month": 7
          }
        },
        {
          "name": "places/ChIJeenqwOmd8kcRI-Y9NfY-nic/reviews/Ci9DQUlRQUNvZENodHljRjlvT21ndE5FWkROelZKTVRobU5VUnFObEUyV2tsbFIzYxAB",
          "relativePublishTimeDescription": "a month ago",
          "rating": 2,
          "text": {
            "text": "when we first entered the restaurant, the atmosphere was so nice! It looked very lively and cosy. The food however was very bland, not special and served cold. It’s a nice restaurant, but the food was just very bad. I would not recommend the chicken drumsticks with fries (fries needed salt and drumsticks were VERY dry)",
            "languageCode": "en"
          },
          "originalText": {
            "text": "when we first entered the restaurant, the atmosphere was so nice! It looked very lively and cosy. The food however was very bland, not special and served cold. It’s a nice restaurant, but the food was just very bad. I would not recommend the chicken drumsticks with fries (fries needed salt and drumsticks were VERY dry)",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Marilise den Hartog",
            "uri": "https://www.google.com/maps/contrib/101364149802015133910/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocI_1HRzwV1nCz26y6o9zXkKR367rNEEMkHQfVJC_oJuHGp4lw=s128-c0x00000000-cc-rp-mo"
          },
          "publishTime": "2025-12-26T21:13:38.499829809Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT21ndE5FWkROelZKTVRobU5VUnFObEUyV2tsbFIzYxAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT21ndE5FWkROelZKTVRobU5VUnFObEUyV2tsbFIzYxAB!2m1!1s0x47f29de9c0eae979:0x279e3ef6353de623",
          "visitDate": {
            "year": 2025,
            "month": 12
          }
        },
        {
          "name": "places/ChIJeenqwOmd8kcRI-Y9NfY-nic/reviews/Ci9DQUlRQUNvZENodHljRjlvT2xSR2RWbGpkVTlwZFdONlIwTjBkRE5ZUlVkd1NFRRAB",
          "relativePublishTimeDescription": "4 months ago",
          "rating": 3,
          "text": {
            "text": "Fun but the food was underwhelming, which was disappointing as there’s a lot of effort in the decor. Undercooked and bland beignets. Cordon Bleu des Fistons was okay but not great - a bit dry. Thankfully there was a great little sauce that came with it. Potatoes weren’t good. Nice service.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Fun but the food was underwhelming, which was disappointing as there’s a lot of effort in the decor. Undercooked and bland beignets. Cordon Bleu des Fistons was okay but not great - a bit dry. Thankfully there was a great little sauce that came with it. Potatoes weren’t good. Nice service.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Steven Reid",
            "uri": "https://www.google.com/maps/contrib/111586714695966962292/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocIlrUabt8DO1cEk8iX2DUFFyHZWtTy7kg34gfS-mXhjF_UC-A=s128-c0x00000000-cc-rp-mo-ba3"
          },
          "publishTime": "2025-09-23T17:03:22.743308832Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2xSR2RWbGpkVTlwZFdONlIwTjBkRE5ZUlVkd1NFRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2xSR2RWbGpkVTlwZFdONlIwTjBkRE5ZUlVkd1NFRRAB!2m1!1s0x47f29de9c0eae979:0x279e3ef6353de623",
          "visitDate": {
            "year": 2025,
            "month": 9
          }
        },
        {
          "name": "places/ChIJeenqwOmd8kcRI-Y9NfY-nic/reviews/Ci9DQUlRQUNvZENodHljRjlvT2pGWmFYWndRa2RhYTFkd1kxbDFPR0pHWWpWRldVRRAB",
          "relativePublishTimeDescription": "3 months ago",
          "rating": 1,
          "text": {
            "text": "Unfortunately my husband has a severe stomach problem 1 hour after eating the steak here. We did ask for it well done and it came medium. Please avoid the steak - contaminated!",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Unfortunately my husband has a severe stomach problem 1 hour after eating the steak here. We did ask for it well done and it came medium. Please avoid the steak - contaminated!",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Alice Lala",
            "uri": "https://www.google.com/maps/contrib/117708094365980333163/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocJ5xUOwcEp-cTZGRn3PdTbXOHf0j6tQi1LvJ_5A_kmu-vorhw=s128-c0x00000000-cc-rp-mo"
          },
          "publishTime": "2025-10-09T21:43:29.522846862Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2pGWmFYWndRa2RhYTFkd1kxbDFPR0pHWWpWRldVRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2pGWmFYWndRa2RhYTFkd1kxbDFPR0pHWWpWRldVRRAB!2m1!1s0x47f29de9c0eae979:0x279e3ef6353de623",
          "visitDate": {
            "year": 2025,
            "month": 10
          }
        }
      ],
      "photos": [
        {
          "name": "places/ChIJeenqwOmd8kcRI-Y9NfY-nic/photos/AcnlKN1pLGVJC10ylL1vWEDDlSvY_eLNXZ8iYs8mWCXjZ-qpM1hi9YBSyc9yl0PeroL4L7j2aczijL5rOrFu75im3zax0ZlGxivZtceJ-JptuzUtNNHteVHfSnKRjTKDCyF6dnQvvHbazafAxvhjUCpR78P6i3rSLMKDh5jGZT4jRwvUj7-wv1DWUWMedbLU7ikhc7GRNafs4q0pFedIgZxjOjcC53HMTgyeB5TnxN23L_FOC_Kqvl4w7ZyG-kBWOTGRo7kKAHRfXzFW535bgOkXgB6hk_z3n9AKBmw3qTR3u7CTAw",
          "widthPx": 3744,
          "heightPx": 4679,
          "authorAttributions": [
            {
              "displayName": "Les Fils à Maman Dijon",
              "uri": "https://maps.google.com/maps/contrib/110469228823008878415",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUZmY7NUdd00WggnvQWt5KqHJcvsUyy00SoGYxSrWa5WDWA9i72=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipPv5jag1dEpQZ2JaTgXsFAPUk4siqFg3r_MPedD&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipPv5jag1dEpQZ2JaTgXsFAPUk4siqFg3r_MPedD!2e10!4m2!3m1!1s0x47f29de9c0eae979:0x279e3ef6353de623"
        },
        {
          "name": "places/ChIJeenqwOmd8kcRI-Y9NfY-nic/photos/AcnlKN3iXw4K9qQxyExZswm3oYXIpr23JIK0mNhPCBKH9CH5Rcz8IZGbsEdZxkyEc0WvRslrnnGT9XlyUYeIm0X2xOIVi-j7MygVUao_vaZgoJOKKJ6sg2m0ULwc1ZfRzREe-dOVohJB-w97rp34OJnsDAao3zWrQhceINT2NMbo7CssAAwCwjsDOhJYULdEI2Oi1JyimgsB4MHtJ3934RMPNpugNdJw7_IZiuyNPDHR_h6XKAw2aBH4h8AvaxPHMcM-RX9vRTA7ZxWZpAiJ5VADjEUtLsL8ym_kUS_JXZLd4xhHQQ",
          "widthPx": 3744,
          "heightPx": 4680,
          "authorAttributions": [
            {
              "displayName": "Les Fils à Maman Dijon",
              "uri": "https://maps.google.com/maps/contrib/110469228823008878415",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUZmY7NUdd00WggnvQWt5KqHJcvsUyy00SoGYxSrWa5WDWA9i72=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipNS9OhjB-RWdiZ-8ozKVoEVA6K4pRtzTqEkVYoy&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipNS9OhjB-RWdiZ-8ozKVoEVA6K4pRtzTqEkVYoy!2e10!4m2!3m1!1s0x47f29de9c0eae979:0x279e3ef6353de623"
        },
        {
          "name": "places/ChIJeenqwOmd8kcRI-Y9NfY-nic/photos/AcnlKN1y3jRaixSwUbzvqxYFeIwbIAYIRvmkwFx8vMnP7dAaOh8P97lnESj0X1LejMHMxOA0-ypJ0b3ISFmC3e3RdFb_bQEIduOzeVWlXFEU4k57BpO7SSXuYD4DrFZS_F3WP3PcyY_EIT3vKnGRZro4F8JA3Q7ECyKATSxudzikyaJk6BSENDCGC3noXS6y17WGsmFlmnfNcXkGyCblpR_3ZuLrN-r-cjmQW-Tynnc-E_tj--0wodKSoaiemTOqURGcQC_yowlw4cJWA-4OJfze2XMPvNPj98fqP9BGnU2N6QSDLVP7HIgNH4beXNY8i5yaOa9bZF_fbXP_oqKCvLyHYg92ZoVbVQ7qC8-RWN3yx5BTx5k48ihBRjlwrghZYq7WJDXIf3jsIbxv_xH-mCHJxxZp5neFscQeX11ubA81w7FYyLlOWIUWHQfu6cpvRg",
          "widthPx": 4080,
          "heightPx": 3072,
          "authorAttributions": [
            {
              "displayName": "Véro et Lolo LELAY",
              "uri": "https://maps.google.com/maps/contrib/110697108570422492031",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocLyrD1wIS9hfEobgDAD1-Uonyffi22YtGXJbQDkMUxx63vRtw=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhAepF8sOOTXUmzQyud-oIQr&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhAepF8sOOTXUmzQyud-oIQr!2e10!4m2!3m1!1s0x47f29de9c0eae979:0x279e3ef6353de623"
        },
        {
          "name": "places/ChIJeenqwOmd8kcRI-Y9NfY-nic/photos/AcnlKN0xzIZhvmlNjsPZfzfo1QcDykMnIIQiAL32dvPaSGWE6jC4wK8P3HIdfoDM7AHli_YhgJWOSaU2WonIAGRmBSJB7zm7FAR6oDmQo5E2IzmccPEsTmFu7h2M2AHkuZB2_6NTWsGohlnZ0WJgPUiCdrBKMkAj1nSOer0ruseUwI3RYtEf3dNbtO3gQoGggKWESkpoGuEgWfjYOgl-zrJ8kjZblXv-tcKPw7N_D85SGYqj9vydO4NqDO_ypGVrnz9UC0nEPPeTinFmRDi3ERf2QU4L_LvToqIMBBBO0ko216LJk_07RQx8nuWNTNWk_coBZ4hVMSmTesgOEw9tvNdKtm07FfAdOmtjifnGPvvwSRW5i-Wr2xETf0W8PCWxpfDmQ64KU31BHSETjbHcYzwOeuuE5FP76V5wgmIGjvbO4QSqhEAWLit9ffuCxMV5d_OS",
          "widthPx": 4032,
          "heightPx": 3024,
          "authorAttributions": [
            {
              "displayName": "Sara May",
              "uri": "https://maps.google.com/maps/contrib/116865408544404316597",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocIz81WB5MEzZvMSUrUb05VGPrpfIT_MOrVxxGyqoRU73zYefw=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhBJ0QHL_nGR_Ki_n57VfMQE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhBJ0QHL_nGR_Ki_n57VfMQE!2e10!4m2!3m1!1s0x47f29de9c0eae979:0x279e3ef6353de623"
        },
        {
          "name": "places/ChIJeenqwOmd8kcRI-Y9NfY-nic/photos/AcnlKN0Qstyu9fb0FAAaqN4UpiLW2tBCTFbzN7Y8lKnbHPoSYJUW5W3dBhe0mbdl91vXp3tFBALKg2EPGNvwax6OKuX4QlSfF7Urj5l6BF4Ls38JO2Q5-9vzj4tVPK7g5fs1v81ajD2ZwRZltQ5G_aKv54GM72XT__d3gD5OyMhZVcTmNbK9JESlHDW2GJSMfukkM4rJvfoWxKfJmJZAFC-38YUVCWXRM1gjOukvAtZwSnB6QKCcZ2-KY38Xh1uZU_m-xo8SnW8fMiCUbrV4d_Rzy_pVNz7Z_k5y9LcaZBcOvCr-MEUBWWuWOvCI_z9i4y-3g53sTLPVhJ2_Hhyw1j9MltLBZ_jaTTvjR_w9oEV4wJX-oL42idSiT_gMMBsWutUJ7rFIDs52x4EwfFYT35kU4VgPD5pD-aM9VUNe-Fl1gOdnxv3iylUyttvbvGJH1A",
          "widthPx": 4032,
          "heightPx": 3024,
          "authorAttributions": [
            {
              "displayName": "Sara May",
              "uri": "https://maps.google.com/maps/contrib/116865408544404316597",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocIz81WB5MEzZvMSUrUb05VGPrpfIT_MOrVxxGyqoRU73zYefw=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhCigNSeg0jQAqBjcgRiGa57&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhCigNSeg0jQAqBjcgRiGa57!2e10!4m2!3m1!1s0x47f29de9c0eae979:0x279e3ef6353de623"
        },
        {
          "name": "places/ChIJeenqwOmd8kcRI-Y9NfY-nic/photos/AcnlKN3DmJ2JNncxgTaecrbzVWILGg-fug2N7FxAENWRMgUqfcRHYP2iGx1OIdRAZTP-JFoQFhaQFg1dh1Nttw2W88Jv8z0VWFYzmd_hoJidthiYK_M4wEiLmZrs8c_zneV51wPa9dIgJ1oiWFeF4t8ued5taJHsEMxQ_tOTn1MD8zOKULhsr0YPaqXQyHlIbAheHtC3nH9gIFhjrjW7NzYpYE9ptq7dHljcb6V2UZ6Ps4i9zaQ1mBw3wDfOrgCx3GFbO4CNhZTk3CbKeu--DdDUAMxKUZp2PPITmSkLGojucJlwUPbjgqwqhabGR_LlakLFGUTcJaLhUPsfSM11dyDp1U3i8qH72rGqo7RLS-KQ6yDQmPSuFLC9F5Zc5fEb3QK0sZMKuL2GKm6T_JtB2-gZmAf1awNcLL2F5OxX3CodpLuR22AVV7V77lHrvQJdeg",
          "widthPx": 4080,
          "heightPx": 3060,
          "authorAttributions": [
            {
              "displayName": "Camille Acbs",
              "uri": "https://maps.google.com/maps/contrib/113718554554406357902",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocI37FdC6dR0JMfvR5UlwaTCiB7SRtI3sTkXY6uaaxv3LU5reg=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhBI4BNhzz89HKo1U0xz0ygX&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhBI4BNhzz89HKo1U0xz0ygX!2e10!4m2!3m1!1s0x47f29de9c0eae979:0x279e3ef6353de623"
        },
        {
          "name": "places/ChIJeenqwOmd8kcRI-Y9NfY-nic/photos/AcnlKN2XaWugX7tPK2s4qUGmrmM6l_zO2N3zYL8tAonKqJdR1WTTdkgzZD9jT-_xAoEFBvG6VrhIIUjpTyQfUMUPdGHo7eXEy7l7JBOgLMDN_YP-toBpEM0RZslyroE7JdOsKrV-VqwjugAKnpch1I_afulafo18DNAiUrA2zBzCVa3zuv6Jkc7GbmgKCSPTkGzCsS0LzUZM29GHYQnbKFwTQGVmPicYyvefLK_AZ9Td_4DeLE2nkFSGaFV4FuYgXTHRpM73I0T0YRuY2jyLaRIwrq2TvNNllJlZjoec2E58wbxFaCQhtI_HpehqgXAyVvZy0hTUQrWtEyzF6qu2V41D-ddG9vwR7YsbH6mUY2vN1gYSR_PNCIcH8c8mLcWIEmvBjWTwi10ebialkFTtxwED1pm51GPszUtVEzCVGQyGIo7gow",
          "widthPx": 4032,
          "heightPx": 3024,
          "authorAttributions": [
            {
              "displayName": "Thomas Viard",
              "uri": "https://maps.google.com/maps/contrib/108795591705270967551",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVlzAh-SJnFZf6Fsl-BXg71zVYSx9VengSQ5DCfStfYJ9s6aXPs=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgIDbrsrGBw&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgIDbrsrGBw!2e10!4m2!3m1!1s0x47f29de9c0eae979:0x279e3ef6353de623"
        },
        {
          "name": "places/ChIJeenqwOmd8kcRI-Y9NfY-nic/photos/AcnlKN2nJnLUJIP4xkUfL87IWOCtk6FrbDGoTQy8d0mt52KoAZjnLjyIrwq6TK1AWKnowEeKxEtfG_CyAYxMPUgjBJxoPKhclMgUh4QdltdJzeRjKvmkqPGveUlAvRxUIAUJyoLn525PAoixUeq5ZRBBXzDOrmqGHNNUR2oT-2hA9ovqqmJJtZep_jsZYXwNjIWQY5UfbUiVTb9BfM2KwJLM3Pj0G8AueOI_u_IQpuLRsdq-5FBmCBwc8ZUlDRn6nUAjSlsXGgUtoR5pMfkBlPqcLRLmB_8YNzIBnttDcbGBrT0Bxluzq69TpNpOoEOwAjyrSIbO0dFmcM9eArSMjRKSp4JLS2F4dpBpuy3srFxIQecQ0qcr6W6W-Wsgp8a0WkMH49MvEHGPTZcUzbQQARAznMjSMRnMZVT1Iwthe6nQRYQaAd0",
          "widthPx": 3060,
          "heightPx": 4080,
          "authorAttributions": [
            {
              "displayName": "Iron Cat",
              "uri": "https://maps.google.com/maps/contrib/111223054915795141536",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjU4Xsgsk5XBSVEzPHd1ls-STYlJM-6zHrei2rBdfvo4PVke5-ZU=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEIC6v6C53v6ChAE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEIC6v6C53v6ChAE!2e10!4m2!3m1!1s0x47f29de9c0eae979:0x279e3ef6353de623"
        },
        {
          "name": "places/ChIJeenqwOmd8kcRI-Y9NfY-nic/photos/AcnlKN18dFypNirSVtOX_c-F93UYV_LHY-AETIxBB5TSU95dyBYDknQQ3I0IcO8NULqieHduPhlOPc6vohCOrko350NtUM3_W70MB0dSAgmdL6Oa7y4Bxrs6GwxGZ50RJL39bmqPN9zSulbOJ5dhuzo5onMeA2YEh6PzPB2XU6wN5CvRlIP2ZMkJbKr-zUvTl6UO93RoZsQvhbHc7sdIpR1UBJbcaXJ1jYGywMFAsGKv08qQT10gzEI22rqSHDt0caWzJn82WS4oQGWKI3mHEnoAcjwiuHzx1NiFaHYuF7Hcfj-Nd-J9tVaJUx1RTUHhAigZvKVYtgVECTHfWfIK94SyY1dN_99W-fAqRYMPi4YX1qKseZWBBt-90Y2LFlbiaxIpnYB2bs_wEBphnrtuopD9yodfEgR5fHgnzv_H1mfCmrf1Cw",
          "widthPx": 3968,
          "heightPx": 2976,
          "authorAttributions": [
            {
              "displayName": "Trente Onze (3011th street)",
              "uri": "https://maps.google.com/maps/contrib/106840638750934877193",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUMHjjFD8kwNnJEAUECQlEv2JDL9aisn0nID7EfItqJEudpRXdG=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgIDc-_jTMw&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgIDc-_jTMw!2e10!4m2!3m1!1s0x47f29de9c0eae979:0x279e3ef6353de623"
        },
        {
          "name": "places/ChIJeenqwOmd8kcRI-Y9NfY-nic/photos/AcnlKN2wX6ObIsI0N4FXh4_IAchWUdNQk7kFeQZLxRnAQuvM16oDMMAWjMaYlXBwOfkVvPdCmTsjLwhM-Gdy0Mbwtke2d8ZGI51GmXOqN-D0J1UX23uwC8rW0bu7Dp4Oa1eax5PRidiQ5ocWsqpQ7i3hAMR6vvlMmgioOzbFXujKzR9unHgWFYAJeI2n9p5umr-azJUOUs2yK4vs4G0iMaXoU0ot_DuJz61y9z_CG_fY9ZbXdYmJKIYCYVGqyMPPSOusJwcAPVzp5msQ_Ras1rBT53sOPTr68HpSwpLhaQWniLQ53WV9zyBA8fU6cMq6BkdSLbr07Ob-qPL969E4M3gYL8OHIcWa5QnR5y3YuthIwSpd1DLEbg_pPRQzlyqimS0XLcHcCsjtwEeZYMiTAXe2eobfW6yH4qiKdx331aWqjGB2sQbg",
          "widthPx": 1536,
          "heightPx": 2048,
          "authorAttributions": [
            {
              "displayName": "Anthony Vicari",
              "uri": "https://maps.google.com/maps/contrib/103815367917339272363",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXirq8tCcc5i-Fw8B0lMPVg_sLZg1u-75FQLijOHXtfE2WcIz8a=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgMDo25yS2wE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgMDo25yS2wE!2e10!4m2!3m1!1s0x47f29de9c0eae979:0x279e3ef6353de623"
        }
      ]
    },
    {
      "formattedAddress": "5 Pl. Émile Zola, 21000 Dijon, France",
      "rating": 4.1,
      "userRatingCount": 3619,
      "displayName": {
        "text": "L'Épicerie et Cie",
        "languageCode": "fr"
      },
      "reviews": [
        {
          "name": "places/ChIJx04KeOqd8kcR9-ElqMxKFsI/reviews/Ci9DQUlRQUNvZENodHljRjlvT2sxTGQxWm9lbGhsTjNad05IbHRORFZ2ZFVJNVIxRRAB",
          "relativePublishTimeDescription": "2 months ago",
          "rating": 5,
          "text": {
            "text": "We came in on a super gloomy day but the welcome was so warm it completely turned our mood around :)\n\nWe ordered poulet à la Gaston Gérard and steak with fries. The chicken was really tender and nicely cooked, sauce is so good as well.\n\nThe vibe is chill and cozy, and staff are all super smiley and attentive. This place is  bigger than it looks, so it’s actually great for groups or gatherings.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "We came in on a super gloomy day but the welcome was so warm it completely turned our mood around :)\n\nWe ordered poulet à la Gaston Gérard and steak with fries. The chicken was really tender and nicely cooked, sauce is so good as well.\n\nThe vibe is chill and cozy, and staff are all super smiley and attentive. This place is  bigger than it looks, so it’s actually great for groups or gatherings.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Cinny Tsai",
            "uri": "https://www.google.com/maps/contrib/103961782326751422495/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUXICLmfIvwVPn9v-h1tL15ykRBnKoWtqgPMTW9DksaG8eQAnDe=s128-c0x00000000-cc-rp-mo-ba2"
          },
          "publishTime": "2025-11-23T18:00:31.514468525Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2sxTGQxWm9lbGhsTjNad05IbHRORFZ2ZFVJNVIxRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2sxTGQxWm9lbGhsTjNad05IbHRORFZ2ZFVJNVIxRRAB!2m1!1s0x47f29dea780a4ec7:0xc2164acca825e1f7",
          "visitDate": {
            "year": 2025,
            "month": 11
          }
        },
        {
          "name": "places/ChIJx04KeOqd8kcR9-ElqMxKFsI/reviews/Ci9DQUlRQUNvZENodHljRjlvT25WMmJ6ZEJUazV6TXpkaFFsUkJURTk1VlROd1duYxAB",
          "relativePublishTimeDescription": "4 months ago",
          "rating": 5,
          "text": {
            "text": "On the recommendation of some good French friends, I already knew where to go. The atmosphere was incredible, family-friendly, and welcoming. The lunch menu during the week was perfect for sampling the dishes Traditional Burgundy wines. Incredible wine selection. Impeccable, youthful service. I highly recommend trying their Floating Island for an unmissable end to the meal! Thank you so much, guys. 🌱",
            "languageCode": "en"
          },
          "originalText": {
            "text": "On the recommendation of some good French friends, I already knew where to go. The atmosphere was incredible, family-friendly, and welcoming. The lunch menu during the week was perfect for sampling the dishes Traditional Burgundy wines. Incredible wine selection. Impeccable, youthful service. I highly recommend trying their Floating Island for an unmissable end to the meal! Thank you so much, guys. 🌱",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Paola Berretta",
            "uri": "https://www.google.com/maps/contrib/105783246010659658977/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVXxbhjHYPq8GNpwCfVnkm8T-rkk1USWn9DZ-KJf9jxKndzHPyJ=s128-c0x00000000-cc-rp-mo-ba2"
          },
          "publishTime": "2025-09-15T12:02:35.350257174Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT25WMmJ6ZEJUazV6TXpkaFFsUkJURTk1VlROd1duYxAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT25WMmJ6ZEJUazV6TXpkaFFsUkJURTk1VlROd1duYxAB!2m1!1s0x47f29dea780a4ec7:0xc2164acca825e1f7",
          "visitDate": {
            "year": 2025,
            "month": 9
          }
        },
        {
          "name": "places/ChIJx04KeOqd8kcR9-ElqMxKFsI/reviews/Ci9DQUlRQUNvZENodHljRjlvT2xoQ1gwOVFVekJ2WW01ZmNGVkhVMk5LV2tWNlJXYxAB",
          "relativePublishTimeDescription": "6 months ago",
          "rating": 3,
          "text": {
            "text": "The service was friendly and attentive. The interior had a quaint charm, although the loud noise from the hand dryers disrupted the dining experience whenever someone used the bathroom. The food was okay, but considering the price, I have had better meals in Dijon. It felt slightly underwhelming for the cost. Overall, it is not a bad place, but there are likely better options available at the same price point.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "The service was friendly and attentive. The interior had a quaint charm, although the loud noise from the hand dryers disrupted the dining experience whenever someone used the bathroom. The food was okay, but considering the price, I have had better meals in Dijon. It felt slightly underwhelming for the cost. Overall, it is not a bad place, but there are likely better options available at the same price point.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Thomas Jansson",
            "uri": "https://www.google.com/maps/contrib/111206892298884802821/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXW7kjkiKbNudpUkNih0-8VRalBMakYl_AftC__AaPfGtuoiaxr5A=s128-c0x00000000-cc-rp-mo-ba4"
          },
          "publishTime": "2025-07-25T08:29:59.196472514Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2xoQ1gwOVFVekJ2WW01ZmNGVkhVMk5LV2tWNlJXYxAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2xoQ1gwOVFVekJ2WW01ZmNGVkhVMk5LV2tWNlJXYxAB!2m1!1s0x47f29dea780a4ec7:0xc2164acca825e1f7",
          "visitDate": {
            "year": 2025,
            "month": 7
          }
        },
        {
          "name": "places/ChIJx04KeOqd8kcR9-ElqMxKFsI/reviews/Ci9DQUlRQUNvZENodHljRjlvT2tWM1Z6QXpSM0pIUmtVd2JEWnVOVEV0UTB0cU9YYxAB",
          "relativePublishTimeDescription": "2 months ago",
          "rating": 5,
          "text": {
            "text": "Very positive experience at this local restaurant. Our waitress was very kind and attentive, the ambience was great with plenty of room and not loud, and the food was delicious with lots of local dishes to choose from. I recommend this restaurant while in Dijon!",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Very positive experience at this local restaurant. Our waitress was very kind and attentive, the ambience was great with plenty of room and not loud, and the food was delicious with lots of local dishes to choose from. I recommend this restaurant while in Dijon!",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Laurel",
            "uri": "https://www.google.com/maps/contrib/102931766839797361980/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocJXSbhVya__7phxdOe5FNt0bEPbyoe_5909Tyb2SWBOgx9bgg=s128-c0x00000000-cc-rp-mo-ba3"
          },
          "publishTime": "2025-11-11T17:46:30.201404889Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2tWM1Z6QXpSM0pIUmtVd2JEWnVOVEV0UTB0cU9YYxAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2tWM1Z6QXpSM0pIUmtVd2JEWnVOVEV0UTB0cU9YYxAB!2m1!1s0x47f29dea780a4ec7:0xc2164acca825e1f7",
          "visitDate": {
            "year": 2025,
            "month": 11
          }
        },
        {
          "name": "places/ChIJx04KeOqd8kcR9-ElqMxKFsI/reviews/ChdDSUhNMG9nS0VNX28zOV9EM2ZUc3VRRRAB",
          "relativePublishTimeDescription": "5 months ago",
          "rating": 5,
          "text": {
            "text": "We had a fantastic evening at L’Epicerie et Cie.  The food was delicious, the service was excellent, and the price was more than reasonable.  Then to top it all off - we were joined by two French musicians.  Overall, this was a perfect experience!\n\nThis was the highlight of our stay in Dijon!",
            "languageCode": "en"
          },
          "originalText": {
            "text": "We had a fantastic evening at L’Epicerie et Cie.  The food was delicious, the service was excellent, and the price was more than reasonable.  Then to top it all off - we were joined by two French musicians.  Overall, this was a perfect experience!\n\nThis was the highlight of our stay in Dijon!",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Leon King",
            "uri": "https://www.google.com/maps/contrib/116422730739239980320/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocJOP6fYiEgynGHxU9EzR_AXWC2uja4YWsRdu09AWHJJAX61Xw=s128-c0x00000000-cc-rp-mo-ba3"
          },
          "publishTime": "2025-08-30T21:16:31.789056555Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChdDSUhNMG9nS0VNX28zOV9EM2ZUc3VRRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChdDSUhNMG9nS0VNX28zOV9EM2ZUc3VRRRAB!2m1!1s0x47f29dea780a4ec7:0xc2164acca825e1f7",
          "visitDate": {
            "year": 2025,
            "month": 5
          }
        }
      ],
      "photos": [
        {
          "name": "places/ChIJx04KeOqd8kcR9-ElqMxKFsI/photos/AcnlKN1BKdWDpVvqa08n91P-61yo2l5-shAOA5pNeoGvQGwO494V7C7OPlgIJANgsapd_TEGUMvqmF92rreGcMFcvQm7iu8NNrXKn1BNaweVXxiWsymL4H6P0g7y0YF8T-rM8R2GRllyrmvKfpbV8Q8KtwsTIHqOV8h87K5yOvitZAp6RvsHkQqaf35UJQgPFQEsC8TxsLexXy1lr158Wn8X4B3HIHefZk0b7tYpxw6sQj1icrppJVfqpwCzHHxwxjn7BrI8y2svZunK8NCErzQD8V16AHlibL1OtlOnrm-jwwBbyg",
          "widthPx": 3609,
          "heightPx": 2406,
          "authorAttributions": [
            {
              "displayName": "L'Épicerie et Cie",
              "uri": "https://maps.google.com/maps/contrib/114334631446679522062",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocLYw5nOT56wP2IPhDF8gw6VPjvzNsDsSTHRYc9kgunp1KjZCA=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipOGMg3qmE158pW1813oqVDhNunEOO-wci-qp170&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipOGMg3qmE158pW1813oqVDhNunEOO-wci-qp170!2e10!4m2!3m1!1s0x47f29dea780a4ec7:0xc2164acca825e1f7"
        },
        {
          "name": "places/ChIJx04KeOqd8kcR9-ElqMxKFsI/photos/AcnlKN3dB8nJPXcH0daYIHgdYQrOJa-jC623s3GjAK0E5JwDaw9-BIDM3-rKU30qk87sLLZeo24lIVLiExP0M49fGjEly3X9ARELUXUJ_8CjJUOmpuvBq6FN8g5u4VeNyPa29IoBGSA6AlQj5rFt-JAzPliUB2g4R5R2q4c9EUno44_aLntrUbyTLWs7IQlDSCVzHXLy0565rHEQtUChYWp0QiidgspA8X3gSA6pqg50yrlQ9BCQxHBkqi32pqf9G_CJBvZtKK3TYGOUw93zcPknwtYJh5CgGi-x4j83SMtUSvewczEUs-Jfeop2fWf22hPFWIUAhDP_M1BTbRT_jyrezAzaPUH1SH6HChF99lyg_tA2purb4hi-RgJH7vxGTJHVjN590-wXj4LcbvbdXaIV9PiitR3xxw_eyM064Zez__dyADcBGXLbkb9NOVjRRwAU",
          "widthPx": 4000,
          "heightPx": 3000,
          "authorAttributions": [
            {
              "displayName": "Ana-Bela",
              "uri": "https://maps.google.com/maps/contrib/108536598383516800417",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXHkV4y6JIJF8XpZrSReXlWDYj4UOyfj0elvxgM3jijxjDTpIO8=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhA-Ozogn5uGWEBSr-Z7h7TY&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhA-Ozogn5uGWEBSr-Z7h7TY!2e10!4m2!3m1!1s0x47f29dea780a4ec7:0xc2164acca825e1f7"
        },
        {
          "name": "places/ChIJx04KeOqd8kcR9-ElqMxKFsI/photos/AcnlKN30eS-k4H32hG4OGyGaB36cXohQyh7x9UCrLs4hgwljqGP7jAbrhSTPwK6JIyh4RTdNd6J7vHB25PJESlf9r_ogMN_BkskK39ULxxr8ssNW_gzSZy9vjyPJGDwuh1xDTBkxHXYRQLqXG2AIw6kW8ul5Nd__HCJJxTzzVgGBq0ITG21AKwHJKs__kxvaot-ReyMs7HR1zH4Ns0eWGO6HGUIuHiIAVzfX1ujV8iHcRrnFmGxwhpo65-fgMmOSARq0WImmzvrDpjwyIc7-2iQ3kQ4AUg0dnu-FhFUXU4_DLG5i4w",
          "widthPx": 1170,
          "heightPx": 1452,
          "authorAttributions": [
            {
              "displayName": "L'Épicerie et Cie",
              "uri": "https://maps.google.com/maps/contrib/114334631446679522062",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocLYw5nOT56wP2IPhDF8gw6VPjvzNsDsSTHRYc9kgunp1KjZCA=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipOt4nHxn6lt7GwlKV3BQSr0x8oejzWobvBASNGz&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipOt4nHxn6lt7GwlKV3BQSr0x8oejzWobvBASNGz!2e10!4m2!3m1!1s0x47f29dea780a4ec7:0xc2164acca825e1f7"
        },
        {
          "name": "places/ChIJx04KeOqd8kcR9-ElqMxKFsI/photos/AcnlKN0Kl1wY3vePQiOiCqk7WuKiTl8iFaE6v9NOJ9zXJCDMTVDeIIdCYWv8-PsQr7zzVI6uxaaARpaHPKPZkql97Y_4kAPs-mDg_2pQRYYPZJmXa28h-G77TSmCOOJ7dMcsMDEdfApQMyGCbpQjnCRjzXqegaJSVgH5rmiTLQkCMNBydr4NLiO6alBMAFK1wC5HwTBmJLkkc1NNUb7UBLut-hk8MHuumJrM6D5Db01rJas4TQ0nvU1lKhu4aOk7a1ErNeRIxA-PvlulwSGyT4oTCNVI_ZmlazwAUEeky02rzinL-VonyyeOGTRYfZ7NLve-80PkBfUTMJzT_mh8268VAszwYrzWEq1NiJAanOYhYD8ctY4qRSXXrGfJqvH3Wguoa6MtLobTJ8hkheGqkMEYLqddIUd0zsepRN-3xW4TdQwPDjUIjLhMiw3-Emfyb8AO",
          "widthPx": 4000,
          "heightPx": 3000,
          "authorAttributions": [
            {
              "displayName": "Ana-Bela",
              "uri": "https://maps.google.com/maps/contrib/108536598383516800417",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXHkV4y6JIJF8XpZrSReXlWDYj4UOyfj0elvxgM3jijxjDTpIO8=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhCDqrr8K4y4SGfQfukNl7e1&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhCDqrr8K4y4SGfQfukNl7e1!2e10!4m2!3m1!1s0x47f29dea780a4ec7:0xc2164acca825e1f7"
        },
        {
          "name": "places/ChIJx04KeOqd8kcR9-ElqMxKFsI/photos/AcnlKN3FoXTYYlH8pIvavNsi2zkqMgSJ3AODTdUuGTqIdK00okefcGNYzrsvIj8Cr5tZuajWcJ9lXNFpN_6-YM_ElWdH5_Pal2PZLIONyped8h039KS-bfVBv7twYZZMtEMB0u9WPcQoD-vZRAMUptPzGfefp9QOtvrLOhAUmdC1mirMIS1-8kkWIepKO41wuw63gjsk0MrlKn0vQyxwKVQBroNkIoAxuigtFkv5uQZh_ZclfOlxKpNAhUxxke9z_nicHrkblXaGBmJUSmv-poHPiSreHS8Y6lNJ_bc_G8RS10K-txO-UZZ4UJHjrbvjhLpGTCl409LDqSLh90p4tsouHLPYQEysA89NvRd-o8WAAK-w2xEpWQN0jIWRc_owfG8wzYQ0i4jyPgB3wtyElA8r74SoeVWmBNwAKu8SZSpzK4JI8LnPJUjf9zbD_oXu5Rhw",
          "widthPx": 3000,
          "heightPx": 4000,
          "authorAttributions": [
            {
              "displayName": "Ana-Bela",
              "uri": "https://maps.google.com/maps/contrib/108536598383516800417",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXHkV4y6JIJF8XpZrSReXlWDYj4UOyfj0elvxgM3jijxjDTpIO8=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhDNoz3BjWPsg7i9mdh-hBBV&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhDNoz3BjWPsg7i9mdh-hBBV!2e10!4m2!3m1!1s0x47f29dea780a4ec7:0xc2164acca825e1f7"
        },
        {
          "name": "places/ChIJx04KeOqd8kcR9-ElqMxKFsI/photos/AcnlKN2r-om4TS9ZKqvoRo-Vm8lL3it7nABeJkJ1_mrc2NeQz7mtek0vbjuhnW7-GRdiH9BwElrTEYmfnIWsZEnmK4wZAs_tUm5hhNO4nU4qQa2cuFhJtQn5uKbpT2PA08oAexB1ts5K_srPcuGM63wlblYkkAi856ZYZb41JaKVVaOa69rMIrAS7Zn-Mykw_bKTpMgKVs9GQ0qNtKJKR_kLv3mJfOZXX7T8BC6Wtal916wECkYMCliKLxCUc_FJfBo4tb_f0plBpgNv-OW54h7cNZMziPAkvfYr0sDiaVrVsQiXTmpDDX-ikE-w5RO11Z66IhAkyofu9ffR2tbad0oCpgVevyrdCW6c_s0TJYT2_n03G0V1bsu7VYNi49d0Bp_63clD9vJlahpRDe3mNjuWWVO57y26gpsob8qwp3hV9UHIQtD91NjxFUWJBkr2BA",
          "widthPx": 1560,
          "heightPx": 878,
          "authorAttributions": [
            {
              "displayName": "Resize Smith",
              "uri": "https://maps.google.com/maps/contrib/109011733583943708437",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXGukS4jBB6EisUMjrYp22WP3X46IYktDDQ6RdMgOHre-NnxfuOdA=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhDrIylKGUX2-3SZdXJ_PI_0&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhDrIylKGUX2-3SZdXJ_PI_0!2e10!4m2!3m1!1s0x47f29dea780a4ec7:0xc2164acca825e1f7"
        },
        {
          "name": "places/ChIJx04KeOqd8kcR9-ElqMxKFsI/photos/AcnlKN27LPiuQo7_-pshxE5wIzFHDbdzRiOxHlNJVpec41uPlF4oMYF3-PRl_aEL-f0lVMnz3aWVcbL4GzV6AgzSzYtId0G5x4cUmU2eP6FLTRuto_d9jiZLIrgjMDiYMyzLVoK2rS5yX2h-Lq17ZHwzC-l04WuKChGbiXMS4FjE85j95NHyXThB1rHEyDuK8ZJsaNpx012v27yxx3NVibk1Dkx0I_YAPejswS0OWUCa_8SrTo7ubdkf_K8W7Js7xhms2uoSU3NkCJgsHMhROlN-PYz3_t5_6GyWvruGoAJ1t6Fp88MeAbrewbnrbWTtMNuGWJUgX5uSglNg0PMB2Q5YBmCkdUuOPhw4xMkeaIa7tZGJaiSUY2cCGYICzsv0JgBVy-HxSILL3rSNEwsnolV7fgVEMoblWEpvgBwwXguzKRHloTcsrmdbSitA7GRPmiAe",
          "widthPx": 4032,
          "heightPx": 2268,
          "authorAttributions": [
            {
              "displayName": "Emmanuel",
              "uri": "https://maps.google.com/maps/contrib/115654186422842314027",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXiCx3dv6KM6OE7L0WwVzYVkWzHF-SclckRJYqBQ5-OS0Iv4B2l=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhBoWf-QGQzXbH9QP0C92m03&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhBoWf-QGQzXbH9QP0C92m03!2e10!4m2!3m1!1s0x47f29dea780a4ec7:0xc2164acca825e1f7"
        },
        {
          "name": "places/ChIJx04KeOqd8kcR9-ElqMxKFsI/photos/AcnlKN2KEUALcxcoh_yaW240Ts19uUY2XfUQrYaAt5a-cWcvKs2PARcIS4SqgapQaSQ98Of2mMY38NDVpxKEufrMcwSBNR9R8E_XRJ-QQxQ8CQoQUon5LSoJ6Pc_zxhsaahf7ostKl6o1ZUqkW67azlhtRBStbbqObYY9fUmY2MSnSwR5U5dwVejAWHCLc79o0YNxWE7BRtGOAOT7JTO-DxjbCYQixaujgCS3aplERmTRVhZWgwX0Qpf5lmKdffvEtkvWH3uLg2V0MXHeJgXgOKsjLKTnmvinsC9F0Uv-7xE3DEWfEzbbSNFcbzjdIMLcnnj8TlotrKAY2XF-l8xfHbOcnmIej_qoqBxMNqEsIRl-6aoT-re9uFJJljOt32j4-uPr98lpPaa0dHPT9X1XgK6Na65WCou-toyl1rHNbKd8q51XKt0",
          "widthPx": 4080,
          "heightPx": 3072,
          "authorAttributions": [
            {
              "displayName": "Rebecca Henderson",
              "uri": "https://maps.google.com/maps/contrib/111180071917647694223",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWIJnrFYVlsHeDuv264iT4nnl9muPf0hVIJuGfk72RFwjVe3q4pMA=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKELa-0c7E8_ftsQE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKELa-0c7E8_ftsQE!2e10!4m2!3m1!1s0x47f29dea780a4ec7:0xc2164acca825e1f7"
        },
        {
          "name": "places/ChIJx04KeOqd8kcR9-ElqMxKFsI/photos/AcnlKN0eQqpLuv-XtNIVxV9xnYE_yygMUFhuozLu7RIC0xzXzzZ3bEuCuJMv-iSKTUbtC_RVU9A-0G-dULKaTy1nGwCuP3L99lAY48mYMJtFikvGOyYXjws542kuQz-md2Mz9ks43WZ0zoaOEiy5zD8F-3A3dFlvv9K4BkczcaZ39BGgmU7jTTn_7U8aEiAAC55tc9yD9-9i8jaYTQsHjfWbFWJF0KNZSe1VK4zfggwAuVOVlkQjTcK3eVPOgn-FvI178zi9WB8HJREmnGWjc5CQwnrOFo9aUM7P9D5PmRKXpKCZa94AtQTTPbZWCBEMCcGT9mzr_shmEcDKwvlhGogHHn_TGvfpc9K-WPHEyT1sih0c8LsStH9I3jCJSSEVdkxoQP32h0q-6yJvcjVkchjbjEtG9LYN8ePNKETMT8xSXuA",
          "widthPx": 4000,
          "heightPx": 3000,
          "authorAttributions": [
            {
              "displayName": "Sage Naka",
              "uri": "https://maps.google.com/maps/contrib/114535104325891448110",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUhNJN3lfCYRCdVMAsFmMX1dz_qioj_0pGKTVheBkCV1iKYVhkyjQ=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgMDg8bSdVQ&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgMDg8bSdVQ!2e10!4m2!3m1!1s0x47f29dea780a4ec7:0xc2164acca825e1f7"
        },
        {
          "name": "places/ChIJx04KeOqd8kcR9-ElqMxKFsI/photos/AcnlKN2TDE03sH202LXhc4zcD3YJ01M_K5acd6jFfS3vFKDTmkW_vKtj69Z8pBfJyr2kVjgutbIfn4GdFaMBHUJhqFAQx7T-jZuSB0zZjkxjzySjMJZzIKhz4VMCWDpOwPjUlb9NCQs7cg4MhWQuuchrdE5RnXGlVpnE5h3geDLe0ZzPvyRbbR8MmeePQKXycUie5_fQ8oXSK-fsyjt-QgIul4kTt1h6axr5vUWxwa7EgVhWP-Ub9TwLoEBG3ogbHks09KCOvY5KHT0aatmvNXvHxGzDgWM3TPFmBRxeX6Wb46pbRoS08lTCVYmrTDJY_ZzXC-vDOy65-YPHKYCij4NPwp5uZ5uQ4mUAV3IRSa3cXpGEgQ3qC_muenEx84vdaeZOBtYAZhnCYsThl97RfsdvDTKXSCbSMY03evT0ckO66zDKARuP",
          "widthPx": 4080,
          "heightPx": 3072,
          "authorAttributions": [
            {
              "displayName": "Rebecca Henderson",
              "uri": "https://maps.google.com/maps/contrib/111180071917647694223",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWIJnrFYVlsHeDuv264iT4nnl9muPf0hVIJuGfk72RFwjVe3q4pMA=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKELm41O6O9qakvwE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKELm41O6O9qakvwE!2e10!4m2!3m1!1s0x47f29dea780a4ec7:0xc2164acca825e1f7"
        }
      ]
    },
    {
      "formattedAddress": "2 Pl. de la République, 21000 Dijon, France",
      "rating": 4.1,
      "userRatingCount": 3911,
      "displayName": {
        "text": "Au Bureau",
        "languageCode": "en"
      },
      "reviews": [
        {
          "name": "places/ChIJKYo1ve-d8kcRPMft_vAx3_0/reviews/Ci9DQUlRQUNvZENodHljRjlvT21ocFdsWnFWMkpFU0dGalJVeGllVk5YZVcxcldGRRAB",
          "relativePublishTimeDescription": "3 weeks ago",
          "rating": 5,
          "text": {
            "text": "Great Restaurant\nWe ate here with my family a few months ago and really enjoyed it. It is great. The food is always really good it is dog friendly and the staff very courteous. Would definitely come back.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Great Restaurant\nWe ate here with my family a few months ago and really enjoyed it. It is great. The food is always really good it is dog friendly and the staff very courteous. Would definitely come back.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Paul Vivas",
            "uri": "https://www.google.com/maps/contrib/111580240328641134543/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWxDdZ8fueltzI6tvg7FJ7Q4AabbtcdIbQyfL8D6ysnNAgVFYJG1w=s128-c0x00000000-cc-rp-mo-ba7"
          },
          "publishTime": "2026-01-07T08:28:01.555211758Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT21ocFdsWnFWMkpFU0dGalJVeGllVk5YZVcxcldGRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT21ocFdsWnFWMkpFU0dGalJVeGllVk5YZVcxcldGRRAB!2m1!1s0x47f29defbd358a29:0xfddf31f0feedc73c",
          "visitDate": {
            "year": 2024,
            "month": 10
          }
        },
        {
          "name": "places/ChIJKYo1ve-d8kcRPMft_vAx3_0/reviews/ChZDSUhNMG9nS0VJQ0FnSUNwbjRqZ1FnEAE",
          "relativePublishTimeDescription": "2 years ago",
          "rating": 4,
          "text": {
            "text": "It is a big american style restaurant located by the road and sidewalk. There are indoor and outdoor tables. For summer, it's enjoyable to sit outside if you don't mind some traffic noises. Meanwhile, the interior design is marvellous to admire. Especially the illuminating long bar with big chandeliers, it will be hard to miss when you walk in. The ambience is rather like a club than a restaurant. It's a perfect place for a night out on the weekend.\n\nIt was my first visit to the restaurant. The service was good and extremely fast. The only reason that stopped me from giving 5 stars was the menu. They were mostly fast food choices. It would be wonderful to see some quality food other than burger and pizza. After all, I guess they are famous for their burger menu.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "It is a big american style restaurant located by the road and sidewalk. There are indoor and outdoor tables. For summer, it's enjoyable to sit outside if you don't mind some traffic noises. Meanwhile, the interior design is marvellous to admire. Especially the illuminating long bar with big chandeliers, it will be hard to miss when you walk in. The ambience is rather like a club than a restaurant. It's a perfect place for a night out on the weekend.\n\nIt was my first visit to the restaurant. The service was good and extremely fast. The only reason that stopped me from giving 5 stars was the menu. They were mostly fast food choices. It would be wonderful to see some quality food other than burger and pizza. After all, I guess they are famous for their burger menu.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Kinki Lye",
            "uri": "https://www.google.com/maps/contrib/114011729605824575977/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjW596CVaGnmFqtHor3wyUIW9WOt-hnP8qpy3UoRXc-n_e_SXA12=s128-c0x00000000-cc-rp-mo-ba4"
          },
          "publishTime": "2023-08-13T07:44:10.810797Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChZDSUhNMG9nS0VJQ0FnSUNwbjRqZ1FnEAE&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChZDSUhNMG9nS0VJQ0FnSUNwbjRqZ1FnEAE!2m1!1s0x47f29defbd358a29:0xfddf31f0feedc73c",
          "visitDate": {
            "year": 2023,
            "month": 8
          }
        },
        {
          "name": "places/ChIJKYo1ve-d8kcRPMft_vAx3_0/reviews/Ci9DQUlRQUNvZENodHljRjlvT2pSbVVWcFZhMjgxWjNwTWNFNHlhR1JFVkZjM1FXYxAB",
          "relativePublishTimeDescription": "a week ago",
          "rating": 5,
          "text": {
            "text": "The food and service was great! Just a little cold inside",
            "languageCode": "en"
          },
          "originalText": {
            "text": "The food and service was great! Just a little cold inside",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Yana M.",
            "uri": "https://www.google.com/maps/contrib/118358621718706770950/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocLoq8NfE9cJGzYj2vFcukH_1QQR9mgc5iG4AF9hwpRPQE53OqA=s128-c0x00000000-cc-rp-mo-ba2"
          },
          "publishTime": "2026-01-23T19:30:19.733435775Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2pSbVVWcFZhMjgxWjNwTWNFNHlhR1JFVkZjM1FXYxAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2pSbVVWcFZhMjgxWjNwTWNFNHlhR1JFVkZjM1FXYxAB!2m1!1s0x47f29defbd358a29:0xfddf31f0feedc73c",
          "visitDate": {
            "year": 2026,
            "month": 1
          }
        },
        {
          "name": "places/ChIJKYo1ve-d8kcRPMft_vAx3_0/reviews/ChZDSUhNMG9nS0VJQ0FnSUNCN2V6Q2F3EAE",
          "relativePublishTimeDescription": "3 years ago",
          "rating": 4,
          "text": {
            "text": "Very beautiful ambience supported by super helpful staff. Taste was good but found little flat.  If you want to spend some nice time with friends  or family, Au Bureau is the place.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Very beautiful ambience supported by super helpful staff. Taste was good but found little flat.  If you want to spend some nice time with friends  or family, Au Bureau is the place.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Mayank Rajguru",
            "uri": "https://www.google.com/maps/contrib/113805981632935307164/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVh9q2-0cuoUbNJAWtGG0GOb9U_oNgnH6PWu3npGXg5zdJI0WCO=s128-c0x00000000-cc-rp-mo-ba4"
          },
          "publishTime": "2023-01-01T19:08:49.422451Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChZDSUhNMG9nS0VJQ0FnSUNCN2V6Q2F3EAE&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChZDSUhNMG9nS0VJQ0FnSUNCN2V6Q2F3EAE!2m1!1s0x47f29defbd358a29:0xfddf31f0feedc73c",
          "visitDate": {
            "year": 2023,
            "month": 1
          }
        },
        {
          "name": "places/ChIJKYo1ve-d8kcRPMft_vAx3_0/reviews/ChdDSUhNMG9nS0VJQ0FnTUNvcHRlU21nRRAB",
          "relativePublishTimeDescription": "9 months ago",
          "rating": 5,
          "text": {
            "text": "We stopped at this pub to have a couple of pints and ended up grabbing something to eat - a delicious burger (Burgundy) like only the French can make! We sat at the bar, and the bartender was very nice. The other items on the menu looked very good.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "We stopped at this pub to have a couple of pints and ended up grabbing something to eat - a delicious burger (Burgundy) like only the French can make! We sat at the bar, and the bartender was very nice. The other items on the menu looked very good.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Daniela Bianchi",
            "uri": "https://www.google.com/maps/contrib/101586735513806074526/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVSHOIPV4gAtCSnywfBnKSx98Har9NLDqtazmaliA481gYAorkl=s128-c0x00000000-cc-rp-mo-ba3"
          },
          "publishTime": "2025-04-16T19:14:10.119253Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChdDSUhNMG9nS0VJQ0FnTUNvcHRlU21nRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChdDSUhNMG9nS0VJQ0FnTUNvcHRlU21nRRAB!2m1!1s0x47f29defbd358a29:0xfddf31f0feedc73c",
          "visitDate": {
            "year": 2025,
            "month": 4
          }
        }
      ],
      "photos": [
        {
          "name": "places/ChIJKYo1ve-d8kcRPMft_vAx3_0/photos/AcnlKN33Hvuxq52xJXA4egWoD_mAIeuKVPwhYyQHsyiDtH7VN7UFebbb8diDwq4X3-0eGgMhi_8YyQRSFKPSBb88BdwE_58mhqeb39kQTA-7cc9AJS3FiuM8gMc52amrPbf1Dt_1S6IMYnw2gwF4tl3cGOj2jyBEnAbVX493qzvNNgiL1_amGF2gRXhCZtXIwyBynj3FLOBVWakay59rfuGAo2KigV7m94Jb6kpcEsyn1uGt35QrklCHtOBIgOtkeD7wfbYdKCsmXCrvM3pukyx_FGGjsN8CKO9jTEtPjsWheYaQug",
          "widthPx": 1600,
          "heightPx": 995,
          "authorAttributions": [
            {
              "displayName": "Au Bureau - Pub et Brasserie",
              "uri": "https://maps.google.com/maps/contrib/107492687895451189354",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVuNfm5RopSHPk1ztc4phUnPpBXUI98FoX_Nh-LZUFrOryg09if=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipO5AJdlomi--_uv_A2wQH5oJneMyDKrboAOKIBh&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipO5AJdlomi--_uv_A2wQH5oJneMyDKrboAOKIBh!2e10!4m2!3m1!1s0x47f29defbd358a29:0xfddf31f0feedc73c"
        },
        {
          "name": "places/ChIJKYo1ve-d8kcRPMft_vAx3_0/photos/AcnlKN1KnTN9Wj66c0e3L-WVDp2qyEj4dDQ6Zgrycz_0XuY9qsFm1Lq_Qd9HU3XOo-SXPaOAycbvIqdn7Ct2cqohRK1wGpbdwyTMgu7gBDrjhR-94_fBW6hoTpxrX8sPw8PAGTZSUPiljxo0XNlhbSFgX0aRM0rSnVr5PSABhw8isg9XIkJWXvMX-KkMoVvw7nOy5zwxMLexD4ydVa5SIaju9DMCzMjEZT3AaC_CIq6g4OjxA3hkeSXNi-cw-sWDRnlrCRhQl2gmoqaJRYTGoE0CNLouhkSxR8LH5hOsu7gHkuD1Kw",
          "widthPx": 550,
          "heightPx": 440,
          "authorAttributions": [
            {
              "displayName": "Au Bureau - Pub et Brasserie",
              "uri": "https://maps.google.com/maps/contrib/107492687895451189354",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVuNfm5RopSHPk1ztc4phUnPpBXUI98FoX_Nh-LZUFrOryg09if=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipN3XUO5uhwt2ooBU_ivqKtuqJTAIpH62YHTT8-0&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipN3XUO5uhwt2ooBU_ivqKtuqJTAIpH62YHTT8-0!2e10!4m2!3m1!1s0x47f29defbd358a29:0xfddf31f0feedc73c"
        },
        {
          "name": "places/ChIJKYo1ve-d8kcRPMft_vAx3_0/photos/AcnlKN266JCynBAsdGYWQSTCelMo5C0eKyADWLzFa3hzIsyTlUEWO_yjMen55Bcd6zPX8f6hFhrTEl9RBjFsP5r6InokBYGNXM4YA2NfwvH5Z4zrgiJ3OYqnG6l11xwTbf8xhNneMoIUEFFEKuv64cVLdSjwuqHPZoddk6x7dUxTzCeOLeas_MZZrqA8OT_GQp4M91oe7X0w46sKXzNjwsoekqhVwOHJtoZ179J5vLvYkAqOOd5v1taDGUcek0W05PnJa6uz1xKpnq9asR7a9ibMEushuVUB_kB0Yn2SrNQ_kNUYx5n5p2HXIP_b17Kh5jM4z83UJ_m3BFDUMPqL26VBzGsufa9yZyLW5Nt_hgDa8uxr0QNesoNU7N0bpgBoyjV4mvEkEuQgzwFMS108OfvVaHYIShghmpYGDrnQ-MDSksY6aBK6gpJdRTKSILx0_w",
          "widthPx": 3000,
          "heightPx": 4000,
          "authorAttributions": [
            {
              "displayName": "Kevin",
              "uri": "https://maps.google.com/maps/contrib/102632423834161836129",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXasMUaPzmJSD_MeYezYL6XHA8v41Vtlum68IyN6O9nurDZ4Uys=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhCPo7aaH30ELXtbyJzxgmlp&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhCPo7aaH30ELXtbyJzxgmlp!2e10!4m2!3m1!1s0x47f29defbd358a29:0xfddf31f0feedc73c"
        },
        {
          "name": "places/ChIJKYo1ve-d8kcRPMft_vAx3_0/photos/AcnlKN3HrFsRZ2pH2qfutxghtMnb8i06LaQHcQ506YpcI2VLpuhMnQURZAz1ZwqIDcV7_jW87FniFCMPGy98KQkjs-rAduIt3TPAIOg55p1nEUQ0Ug-h1Z-xNRGxUg7k_3qNylYaFozEVF1x0YFM0l9ckOnAspUwHVFzBGLWEqbXsdK7IOjXxCscQHNxru9MWmMtC8ozWCiZ9gAs8xoMPQXppIUDpgDlBkoM-xu6xCWFAii8U0UbT8HVnQrZT2omv-uiVvWxzyNezKiZypyFE6rbSokIw9ZFv1eus2xxEXM5Qmw5c52JnKeF-V0XjAe40qZrtsoEQQBRz7qzfQLGkWYD6Ix7NXtzlF1eKuhtOhOWFqV0IE4dPZH6sTRCi4VVmAjh5J-zPWENMpaFUhM8xJK2bkRNp94iQkv874DNZFF_CveitfG181QBKUgC3MXARgnp",
          "widthPx": 4128,
          "heightPx": 3096,
          "authorAttributions": [
            {
              "displayName": "areti k",
              "uri": "https://maps.google.com/maps/contrib/101537247580370363980",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocL-hnKjWinJ1O3RqIEC1mZFSHQrAi7cp4qYg6yaPbhCHYdZ9Q=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhAagREkVbcySgH2OomdddWL&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhAagREkVbcySgH2OomdddWL!2e10!4m2!3m1!1s0x47f29defbd358a29:0xfddf31f0feedc73c"
        },
        {
          "name": "places/ChIJKYo1ve-d8kcRPMft_vAx3_0/photos/AcnlKN3RfQzVC83i9G0oIJVTtEg_9X0cdqguYADK4NksfvNtTiTcLdoQil-wnnhJBDiHCEWr65LEifpAMScvxYChp4ZrgLAb525nn0B-Hoa7DKHltMHwQOGGhK-0HEgwxV0nzpggOMqBI0peRwc8_cH-YPDfnjZUhxvRwxPFb2MiNXJAECCX-lvb-veZFvSEo_EvcORyyes9yGR4gYW-fb8OeP-WXlFLaWWt7g5rb4snR6PSPf7OLGD5PBPsEUtxCWwICT9IQbDNPEGU6eezEs_H5SWxvymZCxheVukWmItPsxmhlGRbem8YmrC_QsBz_hgYU6n62t_wNc1GlDZURctfDCYFyyjrjudBStwI7esb-SAFtaXl_NKeRkkQsdsm8dJGbMoEjp6gG1vQ2zychLnZl8Q0VgVnVk0lvgZ0tsRVMm1Y-N20Yq9B3bzrKAKBWA",
          "widthPx": 3600,
          "heightPx": 4800,
          "authorAttributions": [
            {
              "displayName": "Paul Vivas",
              "uri": "https://maps.google.com/maps/contrib/111580240328641134543",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWxDdZ8fueltzI6tvg7FJ7Q4AabbtcdIbQyfL8D6ysnNAgVFYJG1w=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhAal3TGlT8-i31BAfZ_8ARu&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhAal3TGlT8-i31BAfZ_8ARu!2e10!4m2!3m1!1s0x47f29defbd358a29:0xfddf31f0feedc73c"
        },
        {
          "name": "places/ChIJKYo1ve-d8kcRPMft_vAx3_0/photos/AcnlKN2J5NVmPATR4uh_DQggZxMrbeudT7iXWWRBOcVM5ZEo2ldJyzkTnzSZa9At1y8IrQZY7cVSkfSRuIbc1tAMVzcNQRkbpkwLXiuIQY-9TDFsm9azhxObSRJFkEeLV-cNWFTsBmy-MjW5xUY3INfZS4SVtA0rI-KZzTGdz-kVlFX28Gq-xPkYdFVCsHiBDCrbuWS3NdV-ybvIgnOM2r5LBIXE4ogA4l_gud1ZkGl7I5S0cX48sBSEXB6owE8yAq-i8UO0ddMG23J6vMKVA4cun6rJRb-g9R8sn3IrAKEmUG_VXA",
          "widthPx": 550,
          "heightPx": 440,
          "authorAttributions": [
            {
              "displayName": "Au Bureau - Pub et Brasserie",
              "uri": "https://maps.google.com/maps/contrib/107492687895451189354",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVuNfm5RopSHPk1ztc4phUnPpBXUI98FoX_Nh-LZUFrOryg09if=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipODbpxYhtd-yDh_R6S3qvhOMgDFYG8zRnGwOHeX&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipODbpxYhtd-yDh_R6S3qvhOMgDFYG8zRnGwOHeX!2e10!4m2!3m1!1s0x47f29defbd358a29:0xfddf31f0feedc73c"
        },
        {
          "name": "places/ChIJKYo1ve-d8kcRPMft_vAx3_0/photos/AcnlKN2W8PltdjRT-SpjhtwyAYVUJ2nksVSMBWe1UN90G3BK0RJ23kPYkRW60L8nv3wgBlFzeSbdOybXnEZHGkGlILV-djkguaRLXTkGjsWxRyQCelRFKJUCnxJqKGjShNRO11vPHI_gNo_F6AMA2lugofGCFE5T-Yksocd67nOfY3_Iv7vIMjnndjLNFE6-vq3XrZUnx72Yh6m_EVEiZ0U-WHToP6ASGQFwkmxc64ehMfNBxj4MNOshYpAXF0lpJNi0G9umzu6teOR3p8Im0BTcF6mfVNDBWMaibzABv-6Dniqtag",
          "widthPx": 550,
          "heightPx": 440,
          "authorAttributions": [
            {
              "displayName": "Au Bureau - Pub et Brasserie",
              "uri": "https://maps.google.com/maps/contrib/107492687895451189354",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVuNfm5RopSHPk1ztc4phUnPpBXUI98FoX_Nh-LZUFrOryg09if=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipM98hEnUN_uy5K4vyW3bzIRCI5H0-8gIwJT-_e-&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipM98hEnUN_uy5K4vyW3bzIRCI5H0-8gIwJT-_e-!2e10!4m2!3m1!1s0x47f29defbd358a29:0xfddf31f0feedc73c"
        },
        {
          "name": "places/ChIJKYo1ve-d8kcRPMft_vAx3_0/photos/AcnlKN2HqGPDCg8AnaHajQztQpRVHjyq2qQpy7edw6bdlUkmPctcFBm4hpdEQP35y5WB0H8foBZLw6KksPJNn1Hqfs-pv6KhW-GIStDO8hRDtWwngcKAa3WgvDE6U2o4HirZQOjq4XUZnC3TL5C0j_RemJJPp__W8s_Q0omOq4U4gyQVHNf5pjV8zMXBzk5LGYDozKQfcZk23i4sYNjGWZ_zpwHe1ukYkTjhcQHLGYRtvAhXzKGrd-XfyCM6iIsaTCCAZ8NNmxz-HlAqkJLEoGLdHBJdly5zydGELKIzqNxRFdVNvw",
          "widthPx": 550,
          "heightPx": 440,
          "authorAttributions": [
            {
              "displayName": "Au Bureau - Pub et Brasserie",
              "uri": "https://maps.google.com/maps/contrib/107492687895451189354",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVuNfm5RopSHPk1ztc4phUnPpBXUI98FoX_Nh-LZUFrOryg09if=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipMcDEEkvVdsr3jvVFdQt_csGFEcEC2DpUovY96H&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipMcDEEkvVdsr3jvVFdQt_csGFEcEC2DpUovY96H!2e10!4m2!3m1!1s0x47f29defbd358a29:0xfddf31f0feedc73c"
        },
        {
          "name": "places/ChIJKYo1ve-d8kcRPMft_vAx3_0/photos/AcnlKN10JYNHoZdeEmguyFlDzouT7yv3IBt3KIdQC0CosXeNgPxrSqtjmHh6VIxEX6zjoJvX234F42Q2vpILjM-Kp3uDs63WEch-vHBtfa5yyiLs_5NgDRMJAFYiYo73JEc6qNLpHaIOAemqTna-txo1aI2fGSO2_YFohtAx9WADQf_ESyMHrfw-93dnwxJUgAnyVyPqO-mRji_J9d5N7BIa8GovD9Iq1lwFgsmGfPqKUzu0JkEQy_TkenjFKNL7GQnFG6Ur2aNIHLatJrXjVsbQyGGuU97C3Bd78kJQNS744wqH3Q",
          "widthPx": 550,
          "heightPx": 440,
          "authorAttributions": [
            {
              "displayName": "Au Bureau - Pub et Brasserie",
              "uri": "https://maps.google.com/maps/contrib/107492687895451189354",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVuNfm5RopSHPk1ztc4phUnPpBXUI98FoX_Nh-LZUFrOryg09if=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipPJ9AuDs-2mCevr9FtRdcbTQyWYxZvFr86lIXTz&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipPJ9AuDs-2mCevr9FtRdcbTQyWYxZvFr86lIXTz!2e10!4m2!3m1!1s0x47f29defbd358a29:0xfddf31f0feedc73c"
        },
        {
          "name": "places/ChIJKYo1ve-d8kcRPMft_vAx3_0/photos/AcnlKN37khPErMV8BNdDmeyHNx747yA0WK48JwhSlZIIY2BijcIJZDD1oLiPFPqPq8iOTz7SHqkfUDmgW2iR83juJFRuU5w5zgau7FRoNoTCKcJoZg9b3Y_eQ7qEtKnut1drcVzwooLVxcDD1EkSfRLbl75YH2KblQMeIXabR_km7vaFRHHRdOZOCeNA5JPn7oTqhbm2NARBbYn2DuJ-BNQLNmffpj5ZZYKEmrcTT2KOi-xS2569wGJj9ePWVE6_FJSZ1NNZJWTYyGW-aL4uZRXGCoRO54kFIlIF0Vhpr0QdyWoHCQ",
          "widthPx": 550,
          "heightPx": 440,
          "authorAttributions": [
            {
              "displayName": "Au Bureau - Pub et Brasserie",
              "uri": "https://maps.google.com/maps/contrib/107492687895451189354",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVuNfm5RopSHPk1ztc4phUnPpBXUI98FoX_Nh-LZUFrOryg09if=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipMys3xh6HdCiLlGu6Z3VwL4q1zUlL9g3BhhGj_O&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipMys3xh6HdCiLlGu6Z3VwL4q1zUlL9g3BhhGj_O!2e10!4m2!3m1!1s0x47f29defbd358a29:0xfddf31f0feedc73c"
        }
      ]
    },
    {
      "formattedAddress": "20 Rue des Godrans, 21000 Dijon, France",
      "rating": 4.5,
      "userRatingCount": 1581,
      "displayName": {
        "text": "Restaurant Chez Léon",
        "languageCode": "fr"
      },
      "reviews": [
        {
          "name": "places/ChIJ0WbLoO6d8kcRYB8niO6oAEI/reviews/Ci9DQUlRQUNvZENodHljRjlvT2poblVFVnhVa1paTFVGUVgzUm9PR3RGZG5Oc1YxRRAB",
          "relativePublishTimeDescription": "a month ago",
          "rating": 5,
          "text": {
            "text": "I visited Restaurant Chez Léon in Dijon and had a wonderful dining experience. I ordered a glass of Côte de Premeaux red wine, which was very smooth, not astringent at all, and extremely enjoyable.\nThe Bœuf Bourguignon façon Léon had a pleasantly sweet-and-sour sauce with a subtle wine aroma. The beef was slow-cooked to perfection—very tender and literally melted in my mouth. The creamy onions on the side were also delicious.\nFor dessert, I had the Tarte des Sœurs Tatin with whipped cream and vanilla ice cream. The apples were perfectly soft and bursting with flavor. An excellent way to end the meal.\nHighly recommended!",
            "languageCode": "en"
          },
          "originalText": {
            "text": "I visited Restaurant Chez Léon in Dijon and had a wonderful dining experience. I ordered a glass of Côte de Premeaux red wine, which was very smooth, not astringent at all, and extremely enjoyable.\nThe Bœuf Bourguignon façon Léon had a pleasantly sweet-and-sour sauce with a subtle wine aroma. The beef was slow-cooked to perfection—very tender and literally melted in my mouth. The creamy onions on the side were also delicious.\nFor dessert, I had the Tarte des Sœurs Tatin with whipped cream and vanilla ice cream. The apples were perfectly soft and bursting with flavor. An excellent way to end the meal.\nHighly recommended!",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Yan Wen Su",
            "uri": "https://www.google.com/maps/contrib/109508923549047369966/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXFYO8Ycu1QdDL4iFvB7MK8hrsvBsuyMlQq42SLbWNO5zKND3Lg=s128-c0x00000000-cc-rp-mo-ba4"
          },
          "publishTime": "2025-12-27T21:29:58.964618813Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2poblVFVnhVa1paTFVGUVgzUm9PR3RGZG5Oc1YxRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2poblVFVnhVa1paTFVGUVgzUm9PR3RGZG5Oc1YxRRAB!2m1!1s0x47f29deea0cb66d1:0x4200a8ee88271f60",
          "visitDate": {
            "year": 2025,
            "month": 12
          }
        },
        {
          "name": "places/ChIJ0WbLoO6d8kcRYB8niO6oAEI/reviews/Ci9DQUlRQUNvZENodHljRjlvT2pOelFWOTJNMkpHV1MxRGVFeDJNMGxOTjBaclFXYxAB",
          "relativePublishTimeDescription": "a month ago",
          "rating": 5,
          "text": {
            "text": "The escargots and scallops were absolutely delicious — perfectly cooked and full of flavor. Cozy atmosphere, great service. I’d happily come back.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "The escargots and scallops were absolutely delicious — perfectly cooked and full of flavor. Cozy atmosphere, great service. I’d happily come back.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Marinita",
            "uri": "https://www.google.com/maps/contrib/114637337467605942958/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjX4dfZwv6rD0PN-mvM-vZhrgLo9rzk16_oEbHIQIPLyQ-jUtTai=s128-c0x00000000-cc-rp-mo-ba3"
          },
          "publishTime": "2025-12-04T07:39:29.655345671Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2pOelFWOTJNMkpHV1MxRGVFeDJNMGxOTjBaclFXYxAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2pOelFWOTJNMkpHV1MxRGVFeDJNMGxOTjBaclFXYxAB!2m1!1s0x47f29deea0cb66d1:0x4200a8ee88271f60",
          "visitDate": {
            "year": 2025,
            "month": 12
          }
        },
        {
          "name": "places/ChIJ0WbLoO6d8kcRYB8niO6oAEI/reviews/Ci9DQUlRQUNvZENodHljRjlvT2xOWFUzQm9jWFJyYmtKeE1YWmxSREZWY2xwT2VGRRAB",
          "relativePublishTimeDescription": "6 months ago",
          "rating": 4,
          "text": {
            "text": "The food was good but not spectacular. The atmosphere was great. Unfortunately the service, later in the evening, toward closing time, was very poor. The worst part, we were given a different dessert than what we had ordered and told that it was a tart... I don't know what else to say about this or how to feel about this. I guess it's just plain rude to lie about your dish like this. Maybe you thought we wouldn't notice? Hopefully it was just a one-off.\nOther than that, we're just two Americans enjoying our vacation across Europe trying to be as friendly, curious, and considerate as possible.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "The food was good but not spectacular. The atmosphere was great. Unfortunately the service, later in the evening, toward closing time, was very poor. The worst part, we were given a different dessert than what we had ordered and told that it was a tart... I don't know what else to say about this or how to feel about this. I guess it's just plain rude to lie about your dish like this. Maybe you thought we wouldn't notice? Hopefully it was just a one-off.\nOther than that, we're just two Americans enjoying our vacation across Europe trying to be as friendly, curious, and considerate as possible.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Jason Reibold",
            "uri": "https://www.google.com/maps/contrib/116231001374465393360/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXm88Y4q1fjwpSnm4Xebt30-xkAyPfhSwe0ZRO-0oqVvJ8Fu5wnxg=s128-c0x00000000-cc-rp-mo-ba2"
          },
          "publishTime": "2025-07-08T08:27:35.838191488Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2xOWFUzQm9jWFJyYmtKeE1YWmxSREZWY2xwT2VGRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2xOWFUzQm9jWFJyYmtKeE1YWmxSREZWY2xwT2VGRRAB!2m1!1s0x47f29deea0cb66d1:0x4200a8ee88271f60",
          "visitDate": {
            "year": 2025,
            "month": 7
          }
        },
        {
          "name": "places/ChIJ0WbLoO6d8kcRYB8niO6oAEI/reviews/Ci9DQUlRQUNvZENodHljRjlvT21WSFRUUk1Xams0YURCalpUUjVhRk5XWTNKUmQxRRAB",
          "relativePublishTimeDescription": "5 months ago",
          "rating": 5,
          "text": {
            "text": "Delicious meal and very good service. The ris de veau was exquisite. Very good desserts as well. Highly recommend.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Delicious meal and very good service. The ris de veau was exquisite. Very good desserts as well. Highly recommend.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Benoit Antelme",
            "uri": "https://www.google.com/maps/contrib/104796149575772071135/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocKLlKbYsvtu4gETbYhRfBhyWDJ8O_9BvKaKTc4t5zaG9U2y2g=s128-c0x00000000-cc-rp-mo-ba2"
          },
          "publishTime": "2025-09-04T13:54:07.349003788Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT21WSFRUUk1Xams0YURCalpUUjVhRk5XWTNKUmQxRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT21WSFRUUk1Xams0YURCalpUUjVhRk5XWTNKUmQxRRAB!2m1!1s0x47f29deea0cb66d1:0x4200a8ee88271f60",
          "visitDate": {
            "year": 2025,
            "month": 9
          }
        },
        {
          "name": "places/ChIJ0WbLoO6d8kcRYB8niO6oAEI/reviews/ChdDSUhNMG9nS0VJQ0FnSUQ3MU1Iem5BRRAB",
          "relativePublishTimeDescription": "a year ago",
          "rating": 5,
          "text": {
            "text": "Great experience,  we came in without reservation and they accommodated us instantly (around 7:15pm)\nFood is awesome, real and hones french cuisine well executed, lots of flavour and high quality.\nRestaurant has a good ambiance, without pretentiousness, focused on the quality of the cuisine.\nWill definitely recommend andncome back.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Great experience,  we came in without reservation and they accommodated us instantly (around 7:15pm)\nFood is awesome, real and hones french cuisine well executed, lots of flavour and high quality.\nRestaurant has a good ambiance, without pretentiousness, focused on the quality of the cuisine.\nWill definitely recommend andncome back.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Gerardo Guzman",
            "uri": "https://www.google.com/maps/contrib/112737870742839011882/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXtPaOaqqcUZuIgMX75XxjGGQMN0RYtgJJoEZ7ajtk0CMKXcgb4Qw=s128-c0x00000000-cc-rp-mo-ba5"
          },
          "publishTime": "2024-08-21T18:52:12.411120Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChdDSUhNMG9nS0VJQ0FnSUQ3MU1Iem5BRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChdDSUhNMG9nS0VJQ0FnSUQ3MU1Iem5BRRAB!2m1!1s0x47f29deea0cb66d1:0x4200a8ee88271f60",
          "visitDate": {
            "year": 2024,
            "month": 8
          }
        }
      ],
      "photos": [
        {
          "name": "places/ChIJ0WbLoO6d8kcRYB8niO6oAEI/photos/AcnlKN2xg22CA2kicRKVVGgOhyDIjB3gMV4VhFmcwz0d_Fqzmv0VS6XPNacMchA0vW5-6nJvpHHhvgXymWPv2NlaOyQSm5sV2iE5ADvN9kJirs-ZKgLrUWQXy2v_pRScF0vxpXgtiamebAXjMX9P0tubtxXYoNVyl9qBYqwq_Eo82YhSMz8w7RFt1jQu0IprOVSMyCIkIzE4HRAm4TVZL3wL6xJo0tl1eY_jCK-aNfpazEuayi11W8Q9GzGMm26AP--KXHlsozNWv6vk18N87ZnkW18KaWsxNW92ZDVABb8eiBlDCg",
          "widthPx": 4032,
          "heightPx": 2268,
          "authorAttributions": [
            {
              "displayName": "Restaurant Chez Léon",
              "uri": "https://maps.google.com/maps/contrib/114581767903994898804",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVT624d9S2V1XAUcG4MRFiw6xn9zCgqh9orABBlN7LCmX1mqQo=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipM-XDLGzWSVyiYXde2K5OGVyBPOkkLnVyqcTl2g&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipM-XDLGzWSVyiYXde2K5OGVyBPOkkLnVyqcTl2g!2e10!4m2!3m1!1s0x47f29deea0cb66d1:0x4200a8ee88271f60"
        },
        {
          "name": "places/ChIJ0WbLoO6d8kcRYB8niO6oAEI/photos/AcnlKN17tltOQ5_tePbHlCyafk0Uk8eeXlZHK2-effV5zDG1-Sfzwtugp0D4ZjnV0QUGtE1uwpg8Wz4KUO6-4d3gXKVpKN8oX6njfc5FfrH2QFzGHHBq1kDJkK6fgYhFbCcIFuK8wN7WY9WPEDh3avSWEXTVnBKQn90KhqUqaDOxmZQx439vByZjmEB7i4yqnzLFAqnJO1gcoQ2ZLUUN4QtkxC9MSbZmmcN6Vqyh8IIcMpRwVyiN5uKAOfzM1uSeMV1M9OObQsdGnEwSOt7PHwS-DL4EnKod_p8h1T5yps1mAOkEW1YxA5Z-U6jKsizuAr9JAbsPx1pVgMnALCoZOgzbpWH58zBbcDxEh3HWZByiA7xZuTNChp9Mjx8ECYf-mbqD3HSnrkD-4HdRLSt9NThLVfnAxTvbPYM4QOzsDftdLwCyXA",
          "widthPx": 4624,
          "heightPx": 3468,
          "authorAttributions": [
            {
              "displayName": "Fanch Del",
              "uri": "https://maps.google.com/maps/contrib/114243877042371730114",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXQcIik6Qj5TjiZ7uyNLmXus7RXAttZriClFpwdVQUKWCEZJwU=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgICV8YfGaA&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgICV8YfGaA!2e10!4m2!3m1!1s0x47f29deea0cb66d1:0x4200a8ee88271f60"
        },
        {
          "name": "places/ChIJ0WbLoO6d8kcRYB8niO6oAEI/photos/AcnlKN1BFPADJONQPRkAaInyq9gcRxEpFLfxnx0XOdANQPz1n7ZwYL3WN5Jnk3YAi6jFE34xPVbDGRbEiysmlKF9n0kwtG6OPywB_mPnjdtTYIRQA89gtUmSu3jvrSxtyncY8IctJg9DtjhBvTjwWxj0dmHwfddtomluZ0SJEI-cOyyLQ3A1Di2FJLm33lm7FwbJcrAeuuFOapp6f2EN8VxgXpenx1-7ZcUt-83TVHxZ9TmqO9m6d8MWwogcTLQhyvvLjGMiy8yxE7YN7zAKkRrg9YATGGAl_TzXs6hJSfTafB-DAuLbCRqNc7NCHl-ktenu2caouUEfyIDD5YkzLjNy9uz1AsmxXFptzmRFGugcLpRE5xzluIllNUReDyVUfET-8hVVIy7i8Z9VSpn6N6W3zrEs-fbdKvHI5WwA4xfcu5PN4w1c",
          "widthPx": 3472,
          "heightPx": 3472,
          "authorAttributions": [
            {
              "displayName": "Sofie Ducarouge",
              "uri": "https://maps.google.com/maps/contrib/113416163463768226647",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVWQunmuwRWiPlTQss_OUMwV0ArTKuC-sQ7Acli-B9N2gv42ak9=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEP_2goWArLPs6wE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEP_2goWArLPs6wE!2e10!4m2!3m1!1s0x47f29deea0cb66d1:0x4200a8ee88271f60"
        },
        {
          "name": "places/ChIJ0WbLoO6d8kcRYB8niO6oAEI/photos/AcnlKN2WbadPJd9pL71LhPLRusjR0Z6tsMgVhAyC0PiltY_J7MziZXPomceSd337YKG8657nWi_1YJCKIi7266MWs7QtePKxX8zELbyZE9YyJROgKkwI_-OyhVcWQ8ZHKQtI_T-Z2-r4FL7pd81ykS8_Zhu5geizb7-ymHdhHQEClO-Uycyslk3hEDOAmxkInU6xk5HVJQpiAlBKMZJFNwmInNWpJXW9GUi1LT7PiWiozE7FZa6cBM19G373psvo6Rq8Duam4FCvzKYALqoo_UrDs3fScIxDRWt5g0mPJmSOK9A7H_ObLGf8r-mRD_ruM5wmo8_FBeJseSrmu2FY87Gctisewmv2PfpPCCJt9MgeJn443iX-Nzdmj1OTZ6SKddCP3-cNNBKpeootsykmOQBW_Vk_me_k4borVMhHHWw70vLCFhqH5-HZ2TwVjN0IPg",
          "widthPx": 3024,
          "heightPx": 4032,
          "authorAttributions": [
            {
              "displayName": "Alice Wilby",
              "uri": "https://maps.google.com/maps/contrib/114527112597041642860",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjV1fDkbOOeZSa54vxlLbWsqMJNQSWnQWhWl16pnvVUCm0sI5dpQ=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhCep6jsi6vlsgd8jj99nKa-&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhCep6jsi6vlsgd8jj99nKa-!2e10!4m2!3m1!1s0x47f29deea0cb66d1:0x4200a8ee88271f60"
        },
        {
          "name": "places/ChIJ0WbLoO6d8kcRYB8niO6oAEI/photos/AcnlKN0J4KGhB-eSRy2RkzTzC8HWKy4u3xjTxYA9vlswGZiMAL0S95dO-imW1kB5jgw6PuzUrmEdH38T9qEqvT_zA9_wRsE6RfVoMSLmU526tQ_dP9Hn3esofqmeXyy5_SzERuxdfEwVcgbZ_HfGK-f-vfo_wR53n1YJHbPur8W3vkHdyAZMcRubJf0oww9aiKXEMyIJ_INuGUXYEw1pwoiQlkL_3HiFpZ8sAzZYn3RJSfDRPnsilGjejmiQQ3bu-HpiMgwyOGq77LEyDZ2Sc4H5rsjeKmDgHkPcgV8VSEOL8I_tJak33CuPj7X7gyZCN0rV5JHxXBwcyFONucIhLoRhgTRkkWtY39oqmRK8_2wy8SIAzIi_LZOzB0QZm6vdVbxSIDX9zard9JLijzOm25gaw_msHat2jkjeI3lMfneVUTFk_A1qlWKipQe1i0qbeA",
          "widthPx": 3024,
          "heightPx": 4032,
          "authorAttributions": [
            {
              "displayName": "Filiz Glr",
              "uri": "https://maps.google.com/maps/contrib/111804271405459367320",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocIW4jzvKyYMDwnLmkGbJiacauytsNoGz1khtKQ6mEbwT41EQA=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhDNrHtAi7l2cFLZFHlVGQhG&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhDNrHtAi7l2cFLZFHlVGQhG!2e10!4m2!3m1!1s0x47f29deea0cb66d1:0x4200a8ee88271f60"
        },
        {
          "name": "places/ChIJ0WbLoO6d8kcRYB8niO6oAEI/photos/AcnlKN0HMWlyowZOPzzHgwetXFfoikToKL5tUf4Fcq138gadKuMvVO3DEgm-7gItpZjL0z6uXLqgXJcg2kHmTV54Gqy6oq7FHMG2VqjAbF-lijtG6f3LF0Xj0j_raXBAn0ks34QSW3wbOmtK4mkXQ7ge6WCFsJqP05BcumkTD5eQjjFQELCtjwJbaVvIzlj7EqKTV0Om7wvNwnN47gNnot9UZhErA30FZI6crN1Tg233PH5sQP0Lvmdffqo4MM9qWFxr3az9pD0tH2J-B4u5CL6NfTppmqH1XzXmWdeBm1TyUrRlrP3Teuj7TvNyTIVxAb0qSLkzfuJmUCYQ4quTSTRbVhP1MSipTBPYTZQRGH-YDNR6dfAGJEyE7wMIzPxxdzUnkxtD4_xZTVbl-qcqFUSOtq7rjC4ZSthiKGIJnke9cE9u9zo",
          "widthPx": 4000,
          "heightPx": 3000,
          "authorAttributions": [
            {
              "displayName": "Fabien Sleeh",
              "uri": "https://maps.google.com/maps/contrib/118065230435774468592",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVyZ7eKOX9ek7udsr7oI-iCmkhE1zK_nrUM2ay8hzbt7jgZRwv5xA=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgIDJ-4W45wE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgIDJ-4W45wE!2e10!4m2!3m1!1s0x47f29deea0cb66d1:0x4200a8ee88271f60"
        },
        {
          "name": "places/ChIJ0WbLoO6d8kcRYB8niO6oAEI/photos/AcnlKN1iPELUoFa9Fn1-dR6nzDMZqPxNgRJ0kbKJwj7bvB1VxFxqorTaMLrNn29uokzeYU1aRr6WSF2Nj2OqXtKSmtfB-JBWwCwfG8PDSVAgFQRaYwq9HeOL2wOqAK85OuvHoQ6tPrRCOJT-ZoHPZLkNmbxZ0hBXZm_cQo0tonDcMO8SIwb6NTqyeWOWXxXM7gt6PzHZfeielZgrTLWWidTWprlNHc21rkFvhPr26onjq2wMufqNl7P7DSQa4rQOqycqOq2GiZcK_R4TjZ1rrDeCtggcMXRtFP93rSJ1DTd3Riw6wAH1jaDU30oIF5YFt3S_jlV0SIkJ3UhrzfKElbhJaJKy-SpxwIf0IPabensffB-5WMRiyGhwf66DM27c1lPBSuI7BVFNUdcCeCIGUGzimm6jDL2APzzr1e7JsCv3KAqqW8po8bpQuIc8iwRGR6os",
          "widthPx": 3000,
          "heightPx": 4000,
          "authorAttributions": [
            {
              "displayName": "Supannee Auksorn",
              "uri": "https://maps.google.com/maps/contrib/115556087860600060718",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocLtdAcsvKIHcA6_oP3qKXOwyPLPP7vnJf7GRIyDXT6IIBFxww=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhCZPhxkqrvZOsJ4pRJznQ2m&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhCZPhxkqrvZOsJ4pRJznQ2m!2e10!4m2!3m1!1s0x47f29deea0cb66d1:0x4200a8ee88271f60"
        },
        {
          "name": "places/ChIJ0WbLoO6d8kcRYB8niO6oAEI/photos/AcnlKN338RCfxFihtJI8f7lp9VJD9gpyh_7YzjHoxsN5iO1cfMSw8OitHjejzOnWDZpeP3Fn81c1wGv43AAy6gKTjYW1tzVluUJvj08Q0o7-lT9hqpTpbeF71H4MW1eSgTwfq-XpikUxnxx0lYoHiOaRyw-zu20t9lZTAnBfUObX4Wj_bETeTAsrff-4ig9SJXyBgYv_7ORo97ze7RojWGcqFn_KxRZGBGEVQEzDTz4Vvovaw1honP7FhWn9a2eISewuKH03s8WsSJSk_3aDZHHXncd3tyViIxLAAtZMJKtIrPzTE5e3Fd9dVYHQCpD-Nb2bXk2QZiDER0Ujj79D83dqdNKzEScLNbDzxe0MnklUU5N2_RKWsTYM9TmN3t6rXllwDoJQOKUDRw03cZyQ7w5wWaKi17qBm4tfWJCMc0fcPP7Tl5jl",
          "widthPx": 4624,
          "heightPx": 3468,
          "authorAttributions": [
            {
              "displayName": "Daniel Duchemin",
              "uri": "https://maps.google.com/maps/contrib/102525964530800388450",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUYWqaZb-riCOqDBrUh8HM9ycdVzWXx1ftP8qCvDi0qJlT__Jzppw=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgIC_x76i8wE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgIC_x76i8wE!2e10!4m2!3m1!1s0x47f29deea0cb66d1:0x4200a8ee88271f60"
        },
        {
          "name": "places/ChIJ0WbLoO6d8kcRYB8niO6oAEI/photos/AcnlKN1WOvR5T9hDpH4J7tFkvdFZbPYVtRL6beKQpRsVB-lglxlBAnW2G3io8MYQwZ4oqWY-jpp3LdNAMP5SMPe4eZqoSq8qGAoculJxi1zbVpHVOitmz3PH8yUuss1bVDp4OV9mhY9OFcLOgObKAFxYK9zIL_REae-Pdourt-4pAxphgLNeMlZv3VyR-podMqD7Jz1pfuKRaPdszg3nOfr4WKoX7WMTTVpRQzIOtaHw8y3u2fv1BP8fFhLJC1q4ZlBALvx1tEWGxmmA3pb5pFWMoUDM2SlTOU1AQaSTqBaf_tETupKXxpMHv0iPZCmgu2z7mUqRbgvkmEcErcv1qHEEJtjt0bwYFDBj3vpZo7SjewZlZRIAcMdNbgfZ6QO1UFOxV_AJdDe-_dq5VZZhSxdgD1gTFvMJ7b7cMJ0DqGo10P16cQ",
          "widthPx": 1536,
          "heightPx": 1505,
          "authorAttributions": [
            {
              "displayName": "Sofie Ducarouge",
              "uri": "https://maps.google.com/maps/contrib/113416163463768226647",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVWQunmuwRWiPlTQss_OUMwV0ArTKuC-sQ7Acli-B9N2gv42ak9=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEP3FxumHw820SQ&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEP3FxumHw820SQ!2e10!4m2!3m1!1s0x47f29deea0cb66d1:0x4200a8ee88271f60"
        },
        {
          "name": "places/ChIJ0WbLoO6d8kcRYB8niO6oAEI/photos/AcnlKN1_BCV1VgmUQ1-Y7Nkg49jPQDXeKVu3Zge9V53__GSj4yqou3ApusNRANkuzMLeiqHKiooUD8PFaxA3PqTAvJKMAZCFRO0E-8XwYsruJXXaMFO_fbGWDW2y1W5DFBGWCrKJKMF9DYUZ_gaRx5mdnpUN7tKhQgupOIfo7CJWE5sgfj_vbd2D6rNEdiWdIu3lJQEtFtz8ftOmvLXTmgkkmyythCd9zDDY21zMwRk_JeF3oUU59Oz9LA3zTNNZOJN6_4MuU3pPr0Ou5Yn6gNvEmb0tDkAwHVqTe1J2-WX-GZh0Rhs3vZndMBxqrkflvf94Ma0YQtegcY2NKwA8UOUKjSSG9B7LAbyl4EWQN2uoSEewXNVcHtvm1AGV4ew6ZWLcIxyan4B5ihFrgrIhkfI3kACBx2PHFsb2wCWbsCgtBLBNh6j95gQAkKTMQK2zDKo8",
          "widthPx": 3024,
          "heightPx": 4032,
          "authorAttributions": [
            {
              "displayName": "isa",
              "uri": "https://maps.google.com/maps/contrib/113046255239272263683",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocJwGlmDP-ZE0DgQr6CYPjznY2p8TPLMoJTLDgINICus7UPNaQ=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhCgJDSKRvKh5B-FEFA_loMv&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhCgJDSKRvKh5B-FEFA_loMv!2e10!4m2!3m1!1s0x47f29deea0cb66d1:0x4200a8ee88271f60"
        }
      ]
    },
    {
      "formattedAddress": "85 Rue Jeannin, 21000 Dijon, France",
      "rating": 4.5,
      "userRatingCount": 316,
      "displayName": {
        "text": "O’Crousti Poulet",
        "languageCode": "fr"
      },
      "reviews": [
        {
          "name": "places/ChIJSQX0Xq2d8kcRg0ixeWzE7No/reviews/Ci9DQUlRQUNvZENodHljRjlvT2toMVYwRjRRbEJyTkdWT1UzZG9OazFsVWtrd1RtYxAB",
          "relativePublishTimeDescription": "6 months ago",
          "rating": 5,
          "text": {
            "text": "Me and my husband were on a long road trip and decided to stop through here for lunch and oh my goodness, 10/10 recommend! Food was great and the prices were such a great deal. If I am ever passing through Dijon I would for sure come to this place again!",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Me and my husband were on a long road trip and decided to stop through here for lunch and oh my goodness, 10/10 recommend! Food was great and the prices were such a great deal. If I am ever passing through Dijon I would for sure come to this place again!",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Destiny Panega",
            "uri": "https://www.google.com/maps/contrib/115261294761651964493/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUR_jpKUUsueynKgMujIGPEyYRPMfBGopW3Aw26jE2y-zzmn1Fh=s128-c0x00000000-cc-rp-mo-ba2"
          },
          "publishTime": "2025-07-07T12:44:26.026970793Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2toMVYwRjRRbEJyTkdWT1UzZG9OazFsVWtrd1RtYxAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2toMVYwRjRRbEJyTkdWT1UzZG9OazFsVWtrd1RtYxAB!2m1!1s0x47f29dad5ef40549:0xdaecc46c79b14883",
          "visitDate": {
            "year": 2025,
            "month": 7
          }
        },
        {
          "name": "places/ChIJSQX0Xq2d8kcRg0ixeWzE7No/reviews/ChdDSUhNMG9nS0VJQ0FnSURKLXVlMXV3RRAB",
          "relativePublishTimeDescription": "2 years ago",
          "rating": 5,
          "text": {
            "text": "Very nice chicken! Juicy from the inside, crispy from the outside. BBQ-style. Recommend from NL!",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Very nice chicken! Juicy from the inside, crispy from the outside. BBQ-style. Recommend from NL!",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Dave Mazzavillani",
            "uri": "https://www.google.com/maps/contrib/110109016715953573462/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocIi0_JbvRE55Od7MPTOt-PyZvWavu5ordKia9UEb7b6QH4DTA=s128-c0x00000000-cc-rp-mo"
          },
          "publishTime": "2023-07-15T16:50:30.947705Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChdDSUhNMG9nS0VJQ0FnSURKLXVlMXV3RRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChdDSUhNMG9nS0VJQ0FnSURKLXVlMXV3RRAB!2m1!1s0x47f29dad5ef40549:0xdaecc46c79b14883",
          "visitDate": {
            "year": 2023,
            "month": 7
          }
        },
        {
          "name": "places/ChIJSQX0Xq2d8kcRg0ixeWzE7No/reviews/ChdDSUhNMG9nS0VJQ0FnSUNwdWJuYzh3RRAB",
          "relativePublishTimeDescription": "2 years ago",
          "rating": 5,
          "text": {
            "text": "Great value, the chicken is tender and full of flavour.  I tried both the rice and pasta sides, really tasty.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Great value, the chicken is tender and full of flavour.  I tried both the rice and pasta sides, really tasty.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Julia Ferguson",
            "uri": "https://www.google.com/maps/contrib/106278160579762558662/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWYCFiT4I3pyEPA7mugRnBbEc9aSynv6qfD_lbpJ56hQNSAvSI=s128-c0x00000000-cc-rp-mo-ba4"
          },
          "publishTime": "2023-08-06T19:55:21.321980Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChdDSUhNMG9nS0VJQ0FnSUNwdWJuYzh3RRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChdDSUhNMG9nS0VJQ0FnSUNwdWJuYzh3RRAB!2m1!1s0x47f29dad5ef40549:0xdaecc46c79b14883",
          "visitDate": {
            "year": 2023,
            "month": 8
          }
        },
        {
          "name": "places/ChIJSQX0Xq2d8kcRg0ixeWzE7No/reviews/ChdDSUhNMG9nS0VJQ0FnSUR6amMtTXNRRRAB",
          "relativePublishTimeDescription": "a year ago",
          "rating": 4,
          "text": {
            "text": "Great service and the chicken was delicious! Amazing prices for quality food!",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Great service and the chicken was delicious! Amazing prices for quality food!",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Allison Roseman",
            "uri": "https://www.google.com/maps/contrib/104398043297129633870/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocLWUKtNbJ1J3h3d_sAXIiFsJZoolA5CUZ0pGcc_GrEIhYxyqcqr=s128-c0x00000000-cc-rp-mo-ba4"
          },
          "publishTime": "2024-06-11T12:42:41.768260Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChdDSUhNMG9nS0VJQ0FnSUR6amMtTXNRRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChdDSUhNMG9nS0VJQ0FnSUR6amMtTXNRRRAB!2m1!1s0x47f29dad5ef40549:0xdaecc46c79b14883",
          "visitDate": {
            "year": 2024,
            "month": 6
          }
        },
        {
          "name": "places/ChIJSQX0Xq2d8kcRg0ixeWzE7No/reviews/Ci9DQUlRQUNvZENodHljRjlvT2xGQ2JFcEhVR2RGYmxadlExazRWbE53YjA1SmJsRRAB",
          "relativePublishTimeDescription": "4 months ago",
          "rating": 5,
          "text": {
            "text": "Top",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Top",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Sanchez Magali",
            "uri": "https://www.google.com/maps/contrib/108014680972657630555/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVFFXtG1TBti01DKfGa5QvzFBKfnT2ay-fYlVVoskRnUErDOhSHZQ=s128-c0x00000000-cc-rp-mo-ba2"
          },
          "publishTime": "2025-09-17T01:52:44.784472682Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2xGQ2JFcEhVR2RGYmxadlExazRWbE53YjA1SmJsRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2xGQ2JFcEhVR2RGYmxadlExazRWbE53YjA1SmJsRRAB!2m1!1s0x47f29dad5ef40549:0xdaecc46c79b14883",
          "visitDate": {
            "year": 2025,
            "month": 9
          }
        }
      ],
      "photos": [
        {
          "name": "places/ChIJSQX0Xq2d8kcRg0ixeWzE7No/photos/AcnlKN3tj-8NF5eX7v1IEQm1fQiSJxxisVLhzFekzO1uws_69SiNrv4l41QR7mc0oWas-vfEMfbbRt56dEua9j651cScksC2nHQodw-ifghaRJTgRSSmFv3dmsXoikhI1NiD253JhEzVGW1yM-qKRF-hdjq52LGspnUi_eVi6B0J3p_of7W_2zbgCvXx_KmNDeOUVh7DeI4SiZIGXIaax3YiQVvZVLTfkNj7e_ytoBmYVNBgOn5SnZM3S_ykfSIcmLb4h4JwLie2Mjcynp_IAVTseCbF04qjEL4lV8H6nVaXJFyo3A",
          "widthPx": 4000,
          "heightPx": 1800,
          "authorAttributions": [
            {
              "displayName": "O’Crousti Poulet",
              "uri": "https://maps.google.com/maps/contrib/101384450720121620225",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjW3L_MzcmHbMA0xa-jIWs4O9vgxJ1fVGIHCpyn_Fewtci7u6Qzb=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipMAMLuScOkFqpB6aAt39iPJLTWM5qET11K1Ioun&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipMAMLuScOkFqpB6aAt39iPJLTWM5qET11K1Ioun!2e10!4m2!3m1!1s0x47f29dad5ef40549:0xdaecc46c79b14883"
        },
        {
          "name": "places/ChIJSQX0Xq2d8kcRg0ixeWzE7No/photos/AcnlKN0QiFPV5TCyDivVb5dgD8q6Z1k2ZhEptyQEHLiUOFOWOQTR7LIwRrYt4uTif-jpEumNuLnHC0S9NOyTBw3heO9kaqYmmttxQbwM3EIKqFr81Nd0tG6EO8yprNDikgKVUPDhNrSBZ8zCI8oDd-dgQ4XMPnHmr6fRwGXKKZ2l1l78ql8LXQ7_lMB_PyPxtSxJk694-Lpw6INDTg4mrdEMkWInmFExCdYLRpaT5pmvvNyAssR2xn1z8xzOJqypH6mD1UCqWi6NVhKdTJ8nPmmLkAQuOwNrQeAw0IdM9NeYxP-yHg",
          "widthPx": 1024,
          "heightPx": 683,
          "authorAttributions": [
            {
              "displayName": "O’Crousti Poulet",
              "uri": "https://maps.google.com/maps/contrib/101384450720121620225",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjW3L_MzcmHbMA0xa-jIWs4O9vgxJ1fVGIHCpyn_Fewtci7u6Qzb=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipP-VAV4w6aelFZlF4_XErSIngwrMZoeYwIz2MpU&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipP-VAV4w6aelFZlF4_XErSIngwrMZoeYwIz2MpU!2e10!4m2!3m1!1s0x47f29dad5ef40549:0xdaecc46c79b14883"
        },
        {
          "name": "places/ChIJSQX0Xq2d8kcRg0ixeWzE7No/photos/AcnlKN3RDg2sajbrjh5x7U3x5L7jkp5wNNECmgeHBnD-OKuoTezQHJ328eNPvslCjvC6fKMKep97Nmsz6aQ8X1nIuQUAXlcGunFQUtnBhKWySHqQ6QJZt2rBNJEgCQ9Jh246TVv9pU5J1N-47xXgwkz32RzfGSXrAqIXueaKCwvaYbV7farUm0D_C6bapjNGo1bVW4k7K_D6p1jzA65KyrWqrcemS6GeByfIDBdAdhdn8egeUpPFiqJSt2GuCjHTVW8Fv-MWDi-hqzmuusZm7l-X1092qzm-7cA-d6VHcAuQR3_ckeP8XjQzB7IO42369EEniVmXwM1pHTOthR409jgWXBBnOLd0siRZjslUVUvxD14zA_4VI8F72pBISrADl01im4FWUJfi3zob_-vbXJ8Qm9EuHESTnqVVWviIU0BYG_UyJw",
          "widthPx": 2880,
          "heightPx": 2304,
          "authorAttributions": [
            {
              "displayName": "Amazzal Ecom",
              "uri": "https://maps.google.com/maps/contrib/118356349295858869258",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocJRotd2UiOhJC1etfQTv13a77ExormzxaXiBmjeDXEmZOtjOA=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgID2rIrgEA&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgID2rIrgEA!2e10!4m2!3m1!1s0x47f29dad5ef40549:0xdaecc46c79b14883"
        },
        {
          "name": "places/ChIJSQX0Xq2d8kcRg0ixeWzE7No/photos/AcnlKN2tPtDuUPBMcETtgk173blpjH_E6HyNNEE9ywdus1sXlES9jdW7yHGT3l3-Loz50dQBflErpvfkkDVQ2j2OWv2jvL53dLZpF5Obnj1e_SKBMv_9m1Uw_hoMncnEpWa2HTBZfT8sWxUftKV3vk0d0nbzuzGFTlY9rNPT186ozMsF6A_hxKBIz0txkHJCtxUNNiJTJHvZP1_OuTNdO3DFpZUMWItS3hJGpu4eUVo3xt0qc8aZhD-HYYDIMSlViUEzVJQZK0qyj5SKAQectzq6qaSeMzmtuTwqIYoM_DfMdWVweV0mxq6YcZYqbtQ8Qyj78PxqXRfi1uRPuhKuRmMK_Rwk2NkWyP9HWqfwRZjJzItsnQzW6N_ero50ns157ZtBi_FaiqvTnKDCO8i5-_673DJa86kiwiHAnpmXqZrYUzd5Pw",
          "widthPx": 3000,
          "heightPx": 4000,
          "authorAttributions": [
            {
              "displayName": "Thomas Kientzi",
              "uri": "https://maps.google.com/maps/contrib/106000297347453952093",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjV_riFZ6gozgyPW436vGeYYMy5CrujXdoJ_u3HCd4FwswXv0HQb=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgIDr5PrnOQ&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgIDr5PrnOQ!2e10!4m2!3m1!1s0x47f29dad5ef40549:0xdaecc46c79b14883"
        },
        {
          "name": "places/ChIJSQX0Xq2d8kcRg0ixeWzE7No/photos/AcnlKN3d-IgvQLTWjqOdDrhXyr13wxXEI3n_t9MCRyqw6MfTxJnGUne5GJzirh-QBF-kuJ7SuzIHoykUr0wdeWANI54kAvXddFcTj0l8kBCzKRH15uMKjhGce5DSLjcHwo6WpC_9Z3jPPlKi-y2a4gMf9M_fs2_rfkQdjO95xHyf5Jvl65QRO9uN2s5jP8OkOhgP35DiYdqDkt5O0jxiDhioj7AdtO0B71A0SyB5txPPtV9BtmrDao7hwF_Ork3riNK121WNxsyahPzD2t7DLHmHXgR1-uSm2SMvemRfte2n504JUQ",
          "widthPx": 4800,
          "heightPx": 3600,
          "authorAttributions": [
            {
              "displayName": "O’Crousti Poulet",
              "uri": "https://maps.google.com/maps/contrib/101384450720121620225",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjW3L_MzcmHbMA0xa-jIWs4O9vgxJ1fVGIHCpyn_Fewtci7u6Qzb=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipNdgD2_Ol20W3hruap2MJfO0u-hmACdYtRh0vmU&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipNdgD2_Ol20W3hruap2MJfO0u-hmACdYtRh0vmU!2e10!4m2!3m1!1s0x47f29dad5ef40549:0xdaecc46c79b14883"
        },
        {
          "name": "places/ChIJSQX0Xq2d8kcRg0ixeWzE7No/photos/AcnlKN1oq7D_j_rSpIoYh483scUTXfmo3gmshjhdg0qhHi6JxlFyDFAVR9l5eqsLt3GF1ztSLmjExcWnEZd2TgjHYi5VNw-FUYc29mlyhoPhy0rSu8jjv3IQ7d9XT_HfjnB_LQreDleXyeaSlhYa-HHsTwUq0RfkSYCb_NQP0qPih4bPrK8CwkLJNwo4wg7fsGPHgTzrFbeEdz77FUFsbilRTxDQZNNMcVB00w2sWLld8ZvqZ9Day_fYe1NMIk4UtiJ6oW4WFofpE83D8gFC7XEZK6g09ZiSJx6rr94cKUGEZRHkLg",
          "widthPx": 960,
          "heightPx": 960,
          "authorAttributions": [
            {
              "displayName": "O’Crousti Poulet",
              "uri": "https://maps.google.com/maps/contrib/101384450720121620225",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjW3L_MzcmHbMA0xa-jIWs4O9vgxJ1fVGIHCpyn_Fewtci7u6Qzb=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipNGSvD89O6k1v4NwZHCGlFJDl-gbg5sm0JdbNxy&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipNGSvD89O6k1v4NwZHCGlFJDl-gbg5sm0JdbNxy!2e10!4m2!3m1!1s0x47f29dad5ef40549:0xdaecc46c79b14883"
        },
        {
          "name": "places/ChIJSQX0Xq2d8kcRg0ixeWzE7No/photos/AcnlKN09ZfxNmZIF0P8qplD3AgQHGpGmhe287DF-nW1EI2DbjQe5StNxh5dKUrFIeVKplilJFS3SdHpLXcF2bgHkEOTRX9CMJXUKq0YbJgmiCTZWT25pFroLFs8SYh73HZ1SVBMKPTN1Datmo-FPJY1PsZ_PDKSwbtn3UB8FMQPwqjB2i356Y1-WCutHUDH4A7NgxHHR-w7aiC_Huh_T0FbiNAeREvmfyYobgrpfxs7ysnlBdI-AK6zZFDRLDI2qekyHYTNkzpei7WWIS12MdKKQvUJmc2cGd-La_DrZX8wEYHTK-Q",
          "widthPx": 1024,
          "heightPx": 683,
          "authorAttributions": [
            {
              "displayName": "O’Crousti Poulet",
              "uri": "https://maps.google.com/maps/contrib/101384450720121620225",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjW3L_MzcmHbMA0xa-jIWs4O9vgxJ1fVGIHCpyn_Fewtci7u6Qzb=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipOkd50UKBIdd5ak0spHh0UWPEyjAlMcPa9TLfPH&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipOkd50UKBIdd5ak0spHh0UWPEyjAlMcPa9TLfPH!2e10!4m2!3m1!1s0x47f29dad5ef40549:0xdaecc46c79b14883"
        },
        {
          "name": "places/ChIJSQX0Xq2d8kcRg0ixeWzE7No/photos/AcnlKN3kTgP-avK9vVZyfMLPU-WQEH-ON6WtX2O4GCn9Ka6DG6wKRPolfTiZjue7jypkd_RjhcmExxAt-8IFSuFij-Jx9FnJCYrWVN4RRhEtXghHL3V3p2n5sL8xjK6lR82GHV--FMHFy8HoaFFnpNdnlXp6jxwUqhF3nR-srLi12ISdTmz7js1rUYux_iyoLXXXa1zY76bbN5TbuF3qWwVRgiZWk-cokQFNzkgRLeMLCzSK_CJ79buGhxCP0rE-XCdtpeAReKRbkrL_MFSqSrSiDXaLBAL3OEKiZK4eS2OZqePpSg",
          "widthPx": 960,
          "heightPx": 960,
          "authorAttributions": [
            {
              "displayName": "O’Crousti Poulet",
              "uri": "https://maps.google.com/maps/contrib/101384450720121620225",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjW3L_MzcmHbMA0xa-jIWs4O9vgxJ1fVGIHCpyn_Fewtci7u6Qzb=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipMp3dQK18BmbD4iiZdFpjc3nbRcc5ZLms8P_-9E&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipMp3dQK18BmbD4iiZdFpjc3nbRcc5ZLms8P_-9E!2e10!4m2!3m1!1s0x47f29dad5ef40549:0xdaecc46c79b14883"
        },
        {
          "name": "places/ChIJSQX0Xq2d8kcRg0ixeWzE7No/photos/AcnlKN3elntqx2V_Ju9wM6UhCJnUt86TiFDE5XW2gEhPvDjNFbr7zTQb2C1uAO4DURZDK4ifloh2N5_fSEOA0IQ8BemmEWW56F6vGcZTbwdGuRGiEGTtSA1_UY7dzKXrryBlGBduK3YyndVrn7Vdq73VWLw4wb0rBfJ0lVP5ndFJOMBXfFpiAqhSSJVyAIr37h3OVpZqlAcGl1WKRiW9XTk8mXarltB2JfsxG7zAqppxZXYpC_yU3OmfZh_7GrRMhZM-l3vbHH-uS_tu9cYQr4rj5R0JZC1679km57C4oY90KJHOgg",
          "widthPx": 960,
          "heightPx": 960,
          "authorAttributions": [
            {
              "displayName": "O’Crousti Poulet",
              "uri": "https://maps.google.com/maps/contrib/101384450720121620225",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjW3L_MzcmHbMA0xa-jIWs4O9vgxJ1fVGIHCpyn_Fewtci7u6Qzb=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipPFE86PlI11X27f3ckP7LvnruGAKsK009CKe2vY&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipPFE86PlI11X27f3ckP7LvnruGAKsK009CKe2vY!2e10!4m2!3m1!1s0x47f29dad5ef40549:0xdaecc46c79b14883"
        },
        {
          "name": "places/ChIJSQX0Xq2d8kcRg0ixeWzE7No/photos/AcnlKN3okO7tCw0KuCNK825ZRY1WJulJKAp25Nx8QNgjhVbJCDm-hLDLNiWWs6gvVgwN5WSPE0CSTuYRSHjaAC9DhccRTu9HWUP6Q8CzMtcARKU_hscaonYN1uJ3qpDz3hH2cE2Eg2iXnScOOzTLVeh6QRrAnMlCPo8SqVsLfNwZ7YVsKAqNg4VAxSJQFAriyt5FgCzqyR6_g9YS0wAvXVVpeHVJnlLRF52xDbL8CoXOOkZe2A4CDCtMb94mgu-2iESm5XE89KErfG8HNdraL6DIU-ft7OqcFQCV2iATO716gx1lYg",
          "widthPx": 1169,
          "heightPx": 587,
          "authorAttributions": [
            {
              "displayName": "O’Crousti Poulet",
              "uri": "https://maps.google.com/maps/contrib/101384450720121620225",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjW3L_MzcmHbMA0xa-jIWs4O9vgxJ1fVGIHCpyn_Fewtci7u6Qzb=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipOCJmXnkRm24TijBIH6R3V2lvby_ggkszLobmoN&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipOCJmXnkRm24TijBIH6R3V2lvby_ggkszLobmoN!2e10!4m2!3m1!1s0x47f29dad5ef40549:0xdaecc46c79b14883"
        }
      ]
    },
    {
      "formattedAddress": "24 Rue Charrue, 21000 Dijon, France",
      "rating": 4.9,
      "userRatingCount": 394,
      "displayName": {
        "text": "WOLF coffee and toast",
        "languageCode": "fr"
      },
      "reviews": [
        {
          "name": "places/ChIJAwxBARid8kcRTLKpHPaP6XI/reviews/Ci9DQUlRQUNvZENodHljRjlvT21kNlYwcEZablZoZURWS1NWaDJSREZGTm5CWGJXYxAB",
          "relativePublishTimeDescription": "a month ago",
          "rating": 5,
          "text": {
            "text": "One of the best coffee I had across the world. A beautiful dark blend for milk  coffee, and a slightly sweet roast for your espresso.\nFood is fantastic, but remember that their toast sandwich starts from 11am, so come in for brunch or come twice a day like me 😁 (or talk away)",
            "languageCode": "en"
          },
          "originalText": {
            "text": "One of the best coffee I had across the world. A beautiful dark blend for milk  coffee, and a slightly sweet roast for your espresso.\nFood is fantastic, but remember that their toast sandwich starts from 11am, so come in for brunch or come twice a day like me 😁 (or talk away)",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Denis Fung",
            "uri": "https://www.google.com/maps/contrib/103863021474866329201/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocJdGCXwF17wUJD7txuzsfT8eg2omDsrVO5aiO5VSRkuOfDj1A=s128-c0x00000000-cc-rp-mo-ba3"
          },
          "publishTime": "2026-01-01T08:40:01.036254654Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT21kNlYwcEZablZoZURWS1NWaDJSREZGTm5CWGJXYxAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT21kNlYwcEZablZoZURWS1NWaDJSREZGTm5CWGJXYxAB!2m1!1s0x47f29d1801410c03:0x72e98ff61ca9b24c",
          "visitDate": {
            "year": 2026,
            "month": 1
          }
        },
        {
          "name": "places/ChIJAwxBARid8kcRTLKpHPaP6XI/reviews/Ci9DQUlRQUNvZENodHljRjlvT2tWMlpqSkZjMU5vTW1WaFgxbGpXWHBaTkVsMFgyYxAB",
          "relativePublishTimeDescription": "a month ago",
          "rating": 5,
          "text": {
            "text": "We had a wonderful breakfast and loved every bite. We tried the espresso, flat white, and matcha, along with toasts and yogurt with fresh fruit. Everything was beautifully balanced in flavor and clearly made with high-quality ingredients. Highly recommended—don’t hesitate to stop by.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "We had a wonderful breakfast and loved every bite. We tried the espresso, flat white, and matcha, along with toasts and yogurt with fresh fruit. Everything was beautifully balanced in flavor and clearly made with high-quality ingredients. Highly recommended—don’t hesitate to stop by.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Lesia Sobol",
            "uri": "https://www.google.com/maps/contrib/110426881740881556825/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocLhQHEpFQ2pytYB4C43U2f9zHAL96_chibA7F4o_51ocyOXOA=s128-c0x00000000-cc-rp-mo"
          },
          "publishTime": "2025-12-27T12:25:17.286776918Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2tWMlpqSkZjMU5vTW1WaFgxbGpXWHBaTkVsMFgyYxAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2tWMlpqSkZjMU5vTW1WaFgxbGpXWHBaTkVsMFgyYxAB!2m1!1s0x47f29d1801410c03:0x72e98ff61ca9b24c",
          "visitDate": {
            "year": 2025,
            "month": 12
          }
        },
        {
          "name": "places/ChIJAwxBARid8kcRTLKpHPaP6XI/reviews/Ci9DQUlRQUNvZENodHljRjlvT210Rk1tdERUSEJ6WXpob2JsSmZjMDlPTm1aTVZFRRAB",
          "relativePublishTimeDescription": "2 months ago",
          "rating": 5,
          "text": {
            "text": "WOW THE TOAST?!?! We ordered the Prawn toast and Tofu toast and were absolutely mind-blown! Toast was crunchy-outside-tender-inside and so fluffy, and the fillings of prawn and tofu, with plenty of eggs and sauce, were bursting with flavour and absolutely delicious 😍😍😍 The \"match with mango\" and \"peanut butter jelly PBJ\" drinks were creative, look beautiful but also taste amazing! Was not expecting such wonderful toast and drinks in a small city, great job WOLF, cannot wait to have another matcha and toast!!! 😘",
            "languageCode": "en"
          },
          "originalText": {
            "text": "WOW THE TOAST?!?! We ordered the Prawn toast and Tofu toast and were absolutely mind-blown! Toast was crunchy-outside-tender-inside and so fluffy, and the fillings of prawn and tofu, with plenty of eggs and sauce, were bursting with flavour and absolutely delicious 😍😍😍 The \"match with mango\" and \"peanut butter jelly PBJ\" drinks were creative, look beautiful but also taste amazing! Was not expecting such wonderful toast and drinks in a small city, great job WOLF, cannot wait to have another matcha and toast!!! 😘",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Arthur Chionh",
            "uri": "https://www.google.com/maps/contrib/104370517854516410490/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWiSOLWp8U6M7XuZK0AKLBsknBLI8svB7hEg7nNqH5ib2fqWx4V=s128-c0x00000000-cc-rp-mo-ba5"
          },
          "publishTime": "2025-11-23T14:12:25.816112456Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT210Rk1tdERUSEJ6WXpob2JsSmZjMDlPTm1aTVZFRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT210Rk1tdERUSEJ6WXpob2JsSmZjMDlPTm1aTVZFRRAB!2m1!1s0x47f29d1801410c03:0x72e98ff61ca9b24c",
          "visitDate": {
            "year": 2025,
            "month": 11
          }
        },
        {
          "name": "places/ChIJAwxBARid8kcRTLKpHPaP6XI/reviews/Ci9DQUlRQUNvZENodHljRjlvT2taRFMxSXRRelpOZFhacVlYbDNkSGMzYUV4b1VYYxAB",
          "relativePublishTimeDescription": "4 months ago",
          "rating": 5,
          "text": {
            "text": "We had a pleasant breakfast/brunch.\nThe food was DELICIOUS and the coffee was so well prepared … Mehdi, the sir that attended us prepared all the coffees with absolute mastery and he was incredibly friendly.\nWe recommend 100%!",
            "languageCode": "en"
          },
          "originalText": {
            "text": "We had a pleasant breakfast/brunch.\nThe food was DELICIOUS and the coffee was so well prepared … Mehdi, the sir that attended us prepared all the coffees with absolute mastery and he was incredibly friendly.\nWe recommend 100%!",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Francielly Paolla Guedes Rocha",
            "uri": "https://www.google.com/maps/contrib/110004763416314751524/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVlV3VqcIhqY8zj_K02tdkLTPHA4anU9gzTPPHN3nSadNo2RQE=s128-c0x00000000-cc-rp-mo-ba3"
          },
          "publishTime": "2025-09-22T10:46:50.925571528Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2taRFMxSXRRelpOZFhacVlYbDNkSGMzYUV4b1VYYxAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2taRFMxSXRRelpOZFhacVlYbDNkSGMzYUV4b1VYYxAB!2m1!1s0x47f29d1801410c03:0x72e98ff61ca9b24c",
          "visitDate": {
            "year": 2025,
            "month": 9
          }
        },
        {
          "name": "places/ChIJAwxBARid8kcRTLKpHPaP6XI/reviews/Ci9DQUlRQUNvZENodHljRjlvT25aWFdscGtPRGxTUkZsTWVXMHRTa1kxVkZFMGFtYxAB",
          "relativePublishTimeDescription": "4 weeks ago",
          "rating": 5,
          "text": {
            "text": "Cozy little café with a great atmosphere. We tried the oat matcha latte and the salted maple oat matcha latte, both were delicious and well balanced. A nice spot to relax in Dijon.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Cozy little café with a great atmosphere. We tried the oat matcha latte and the salted maple oat matcha latte, both were delicious and well balanced. A nice spot to relax in Dijon.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "A. U.",
            "uri": "https://www.google.com/maps/contrib/112658417539651225283/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWtodiqVwPyi3h9Klas6Q64n065TYIHT_Azz8gpFMJgc7--TP_NQA=s128-c0x00000000-cc-rp-mo-ba3"
          },
          "publishTime": "2026-01-04T21:23:02.132685197Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT25aWFdscGtPRGxTUkZsTWVXMHRTa1kxVkZFMGFtYxAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT25aWFdscGtPRGxTUkZsTWVXMHRTa1kxVkZFMGFtYxAB!2m1!1s0x47f29d1801410c03:0x72e98ff61ca9b24c",
          "visitDate": {
            "year": 2026,
            "month": 1
          }
        }
      ],
      "photos": [
        {
          "name": "places/ChIJAwxBARid8kcRTLKpHPaP6XI/photos/AcnlKN2v4pYeiLBm6NvFfth7sFKwCGWg0csTqyskw5JKmtWhUGCAm3s4U4vkVb0jkhE-QFUoS0rYpP6NzDUkV5QMXHVNT68U_43w3QZvkZLYpRHbrto2N_wMjWtUzC0OpPFa8I6ox4Nsuip6KxpEDMB8weIT1o3wLnZUwtg7xCDpr56x-cCsdqfpTExocMTO4eEsTUhcuuyBbTNY-iZE9ZkmJZdeOJXGi-kg337EKK-DV-9EdOk9bJ8gGwnvmU-1PSsx50sfdv30KNm1tc6ODQjdq_2dj1_k3wSoECl_ZJ4g7QyYkQ",
          "widthPx": 828,
          "heightPx": 1792,
          "authorAttributions": [
            {
              "displayName": "WOLF coffee and toast",
              "uri": "https://maps.google.com/maps/contrib/118195517366630375749",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocJ2NlYhO_tjPj2NAz2sYSnvUGtzX3J2LF5wZUSmXRR-M-bOrg=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipNav2ccri33RjVAiVrMc1yJNiqFDkyxPX68cfPt&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipNav2ccri33RjVAiVrMc1yJNiqFDkyxPX68cfPt!2e10!4m2!3m1!1s0x47f29d1801410c03:0x72e98ff61ca9b24c"
        },
        {
          "name": "places/ChIJAwxBARid8kcRTLKpHPaP6XI/photos/AcnlKN0FXJgmn-1OigCUanX6rX7uz7Fb-mQnTs_C1Qxgf4Lq7weu_RCcGBMyhyLI96Tnrjugj_36olMyoEUpwyxEaDuL9ZmV76cljuaH5WUiGmo7CoaOWNxdDdjgrsCszSaWq432PwKgrhbV35vvpJdEYXXdaom5mrfLFFO2OtkdI7awjwc44yHj0nFXF5MI5DfB7efVoI7dSUIur0cAheIIs0WRAll2C4AOqFt95roQVyvSLqNsASI8IfOVEkix_xTGP0VIpCjYLCKKEAtLu-J7iQPmlVJUpQaVG-cj6aawjv9E5w",
          "widthPx": 1289,
          "heightPx": 1289,
          "authorAttributions": [
            {
              "displayName": "WOLF coffee and toast",
              "uri": "https://maps.google.com/maps/contrib/118195517366630375749",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocJ2NlYhO_tjPj2NAz2sYSnvUGtzX3J2LF5wZUSmXRR-M-bOrg=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipM3ZJi3Y3BTr-_y95Rp7Qj0WNOdAzFP2cT-nDlG&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipM3ZJi3Y3BTr-_y95Rp7Qj0WNOdAzFP2cT-nDlG!2e10!4m2!3m1!1s0x47f29d1801410c03:0x72e98ff61ca9b24c"
        },
        {
          "name": "places/ChIJAwxBARid8kcRTLKpHPaP6XI/photos/AcnlKN2QAxa9yIvmEo3XzYjmCuVqZy7_F5U0uHyrkptLF6fc8SZm2r80fXpsnEojMjvgT8YyilDuZ_q1l3dqo_9wYtkXIGZxjHAviQI8niIvrh7BAr7mfseOEPQNTH3ToLoltY0r4yyp03hY-wvnG-9GoN7qBbzD3htRLJg0jtI2UjAP_yiqKrZkASu0TCxp8y2itvIRNJpslOXg6Ghi1Tot88HQNDkXnTCJUs0XgA_3h1vZ9P17B2ZSunkWtlaTuH8EbIiIxfQgqsz_a1QnxmzixXLIl3rGPxieoGNXhp7ou38Uum6C3raUbsSQxK1d6EbSP-PV0hJVH95ZCthfKJOuPYUwayq7TyGLEuJFItoKaEaA1XTFnwOoKw5ZhP4QPtjLtfeAItmt3UZb46ZDaDKi3hvsykJrktopUDK8jvxjgstjsxHBdyCLoJLXTNBhrZ3I",
          "widthPx": 4032,
          "heightPx": 3024,
          "authorAttributions": [
            {
              "displayName": "Lucas Degen",
              "uri": "https://maps.google.com/maps/contrib/106420890351211154159",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUED4rAXs9ZUqepfC-y0gVlsMmPF8K44c_U8Ztf0fAelq1RfwRa=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhCZeKj_wJOmp0BuLn7YI9Ts&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhCZeKj_wJOmp0BuLn7YI9Ts!2e10!4m2!3m1!1s0x47f29d1801410c03:0x72e98ff61ca9b24c"
        },
        {
          "name": "places/ChIJAwxBARid8kcRTLKpHPaP6XI/photos/AcnlKN0aiv6MnPMVOrqXPA0iERlk6ygRnV-p7MoXJEJqbI_OBkm5saeOQC0EFa_PEMGu80Gu-ARjLPllHJYYje_4BXhtW-TjvEMASHmQmkZKVN9pF4egZNQHkS6QKeujCbYx18NZUZyl4l3kV5fCfEwwBWpT9hV9Au1Lo8Ci3jFKRdgl_O_9buNTA7x0Hu5vyjIye3ZIomVhRv3mkf04RrvOXQr_D9ZDKtfJWwwEK-zcKxx7KtfCU1leaoGC91cFjKie7FpUyGquOXI6RyHS0AuOa5ueuGQMrbksFFdjTVa6gdgnLlLf5IbymGNxRxnQMaAY9hjt2_cBYqgVGeHAY60zSDakaemH9kcTdoxtyHZ4TgclaeU0tW6dBtgxFl4QW5rHxPWjfDOvPji7Xr5tRls4Q2BIEzk60ys048aHhw4VQNnK4KW3i51sG7Ssd7AyHod7",
          "widthPx": 3024,
          "heightPx": 4032,
          "authorAttributions": [
            {
              "displayName": "Nela Lichková",
              "uri": "https://maps.google.com/maps/contrib/105039003189785804352",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocJinXgwzSDCfTnFWVh7MVrqGaxLgNsPmnnYiMZHJ8Ue7JQoNQ=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhDMstqrqKk_g3MyR-MRJa3i&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhDMstqrqKk_g3MyR-MRJa3i!2e10!4m2!3m1!1s0x47f29d1801410c03:0x72e98ff61ca9b24c"
        },
        {
          "name": "places/ChIJAwxBARid8kcRTLKpHPaP6XI/photos/AcnlKN13fFCzs_5S_3AVY1Io6r-JKB6NDXK-zLikx-Q21d36RQwshN9ghfggC7scY0ZKduGqbxtQf5_8ZmPyGlZl1LTq1Iz809pzEh7j00J5XcF7C1sfEi0HJPxEuTieiLef5_pVZ9KHXp8voe4fB5WBn_wFKCkK_kJkMaZofF1of2jMSMK1xEkSGlyGr64mvSz5FII7gUGVKEPkUyVHL_XrSh781aB7_zVk0YVZmFILHE_ytn5hRE_r4YeFe7kArE1oI6TKhd7c7ODeZt-cvfOXR7hgWfvXT6VHCMuknZwy-dl0WfXkMg5YbnhJLGQDF1U5kSjIamrzdPBB_LjFlWahLPNj67vdSxXq1mpWwOeyXfeK4D3KAUkXvOrDDbHjNGoZ2F5uyNtCdK6TS8qf4ipzqOR3syMZRdXIzuRwfHoQG6fv54AnxSqT0ghIKwTGuQ",
          "widthPx": 3600,
          "heightPx": 4800,
          "authorAttributions": [
            {
              "displayName": "Dominik Kumer",
              "uri": "https://maps.google.com/maps/contrib/102384713932966409067",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocIo9a68AjgjB7JvdyfQ9asOq7gpL3WRyZbd-27uiSsBlb-p9rY=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhAaNr95R-_TTym67dA61fPS&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhAaNr95R-_TTym67dA61fPS!2e10!4m2!3m1!1s0x47f29d1801410c03:0x72e98ff61ca9b24c"
        },
        {
          "name": "places/ChIJAwxBARid8kcRTLKpHPaP6XI/photos/AcnlKN2i_9qc13d93B2wOCnZP9dW_nVAT0f89vCpE3rRJzmnHleAspeP-EfoHIJNLV7JLScEU4OjOe6Yy_MEdwXY1AVNyZpIxC6UrfwM-amxmyVsyA0X58u_gUXCPuQL9YM_VoT9X_tA95XQBggWN4XHdTykBdupJjVSg2rnB7d7VaS_0j9NpQperVT--6meoYDh-QReaAyTPSE20Jisgr1uwHb7XbSUBteqA56rqdZnWZgvgWHzG4OE5fZ5TapnkmqkHzyyBep-gL2yAhMeq0KFIQwN-11nIhWJ8JYHOgYJKeMAMPr8rBr_yxpQW-9L5kgqNtNnUinfZ8c8dbVq13Q6XU0Ts3AfPLIoQB9RjZbBNFoqLx50pqTfysLxDMnzsI-pCrkkN5Ve7UEqXcXzrxzhPP5VTO8IHIBCC-Hhcsn4FFicFQ",
          "widthPx": 3023,
          "heightPx": 3769,
          "authorAttributions": [
            {
              "displayName": "Manon Finet",
              "uri": "https://maps.google.com/maps/contrib/107288712731857341434",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWkfAKxMVst4wqNQbPVL8hNMkHebyZ1hd0E7VH1s_iXJj1gXeeX=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgMCA4JTcNw&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgMCA4JTcNw!2e10!4m2!3m1!1s0x47f29d1801410c03:0x72e98ff61ca9b24c"
        },
        {
          "name": "places/ChIJAwxBARid8kcRTLKpHPaP6XI/photos/AcnlKN3TbVb5-yp8wRgwelqBajspS5F75mo5IDKGke1oK_iw4wwisZMC_1t3gtvGXwxTkTmbVsU82YnD0Z9kE272-NtUudUlJ4DyIejOugLoisrLIAwdKAWYc3XgLpKyDjFtrXnRt_-nP37Xnm4jLl5BQ-zsYZLSZEpEY0X2mqfXol5T_ENoD1mntdso74xKAtEqk_LkZ0qEIaK13YtUa60A3n32rqcqpsiZ98Uv0SADNqt4p3KE6nx-LPdrutuhQdAXW5cZVgtthaHK10Kq8PWfx3i0suSE1ewxpV_tNapfw1BEsuap3siu1ln2sB9mKz98nCQOZ_l_1iBGy9EwJrj3BcaTANJ-WbkYAJgBhC34ihPU_zmd9DDF3AT02aqmV4_80L-i8H7926YZTILOJ2_xZcGniyWL-bOnzP87PuEUHIVKtbrA",
          "widthPx": 3024,
          "heightPx": 4032,
          "authorAttributions": [
            {
              "displayName": "Manon Finet",
              "uri": "https://maps.google.com/maps/contrib/107288712731857341434",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWkfAKxMVst4wqNQbPVL8hNMkHebyZ1hd0E7VH1s_iXJj1gXeeX=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgMCA4JTc9wE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgMCA4JTc9wE!2e10!4m2!3m1!1s0x47f29d1801410c03:0x72e98ff61ca9b24c"
        },
        {
          "name": "places/ChIJAwxBARid8kcRTLKpHPaP6XI/photos/AcnlKN3zh4OIDqNSt0BajUu2tIcKWyWuGzKe1HRxTGQa62zKJ88qjnp1jxwKV4g50mBfp5tT-u9oA5UgRuDUPjBjKmWR-kWAUVEIB-kWWBMSQygu6o8Srugvw1YXrmcNO7tlwil-P3hnZX6ao45jkfoClDoEZtjgkJbBUUTBieyXGzOZC8UIbxCkgehG23-Bc9jxsjwWLS32u8szzpt7wLU8jCNMwC4shdFVaM2vhGDdMbbCITozUd71o0Uka6kO5NWeLcGS4kThMfRmuMCB1GO4h1dGrFAKZycyEhmTv5L-cQZGux2Lmnt4tYSsmaU9-59O1a4i92Lc6CQQYalEKWZ3JaG4yie7qCQwVSCC-brMQjHOwlzJh_CnZaHoqhk_vttXywQ-UnYqxTpsNzu_VnN-Q_nFxft175779iWE8c_wbAytKFg_sLvc73Hpk_h-wANg",
          "widthPx": 3024,
          "heightPx": 4032,
          "authorAttributions": [
            {
              "displayName": "Nela Lichková",
              "uri": "https://maps.google.com/maps/contrib/105039003189785804352",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocJinXgwzSDCfTnFWVh7MVrqGaxLgNsPmnnYiMZHJ8Ue7JQoNQ=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhC_5SuFH1e_0FvSit8y_nHg&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhC_5SuFH1e_0FvSit8y_nHg!2e10!4m2!3m1!1s0x47f29d1801410c03:0x72e98ff61ca9b24c"
        },
        {
          "name": "places/ChIJAwxBARid8kcRTLKpHPaP6XI/photos/AcnlKN0NVZPjG8eBv6Wf3eM79Wzhm-8qSEcMV-6pUwR2GQFMAkXduTn22VMBKYmfjf8M1qywKypGnzG3YO8y_O2kPjhPtL0BMypwMD8wJQR7bLnGWXDMFNCqzeW2CTq6r0SfRtStxTkOZdZzTAjGjExz0FEZzQMUUeKhnqDLmYekmk6VQRyX7Cln3bEyJJtLgrUiYU8qTre_WoMt2Gr-RKlJEGMI6HYzXcvU5fBq3ieYDlA4g1HGn2U39tol4XmVN_9TACrkHkn8eUShBkJKEauuDh_wQ6odLo1mYHDnfiwHqhtcG5BRf5sA7z56gyqEqvMKFF_Neoh3jdj3GksZNY2j5gsFrcTmig4bDNthyRUPpLL3RikpcKE5vXMrHUPWmJhFrPSj4j8NijSkR4NQZcjw1H2Uj5bHYFpdQgZnzqJbbRvVbel2HVxAr4cHGVugHg",
          "widthPx": 3024,
          "heightPx": 4032,
          "authorAttributions": [
            {
              "displayName": "Сергей Корочкин",
              "uri": "https://maps.google.com/maps/contrib/113876853992743602548",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjV4lKDo_JNAtxh-O8BJFK1469KrqXlwNnczAPQq_Dxa7Wjxid3k=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhA6wlA1TdeRJHW73CObw8Ce&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhA6wlA1TdeRJHW73CObw8Ce!2e10!4m2!3m1!1s0x47f29d1801410c03:0x72e98ff61ca9b24c"
        },
        {
          "name": "places/ChIJAwxBARid8kcRTLKpHPaP6XI/photos/AcnlKN2yF6Zy520zx2O_aQUYdEgu2lIpX1-v3FxbLplcCzy2XAd8I6oFAfA5lbcY8FgF_d-zW4BjPMSMFyYKQbZweV2MVZnEA0CbfWtPkzIea48J9_Kgdm-54vjG3thqzMycY71_t6ZSuQUAR0xYIBHQd5_TRhhO7HG6a2stdBqxrAGOwbRdCJ-R-5YpmEUft3w2y8l4zMoNySQfDER1Q4_hvgdz3sAe898880SGy7tQBSkISaQQMeQmnH9q0G7buGJerdsSuoxbaHAsGljKe-KxyIFAV9BRzbK8-CpixoVLHeD-qs_1Ngvab3a_sDINW9PEp-JMzNYAkUHnGmrxTj4_Rm93UPCd_1wfukDB0K5TrdzueflDozFFWIx73E_TkpXdVDE9_1OdcTK5t-GCiQHN46EA0LVXvQP3VaYws7EM5nnjcL1DAmeazUnh6Vt94A",
          "widthPx": 3600,
          "heightPx": 4800,
          "authorAttributions": [
            {
              "displayName": "A. U.",
              "uri": "https://maps.google.com/maps/contrib/112658417539651225283",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWtodiqVwPyi3h9Klas6Q64n065TYIHT_Azz8gpFMJgc7--TP_NQA=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhD8WqDQd3yVhihxN0cNbboU&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhD8WqDQd3yVhihxN0cNbboU!2e10!4m2!3m1!1s0x47f29d1801410c03:0x72e98ff61ca9b24c"
        }
      ]
    },
    {
      "formattedAddress": "5 Pl. François Rude, 21000 Dijon, France",
      "rating": 4.3,
      "userRatingCount": 1034,
      "displayName": {
        "text": "Delirium Café Dijon",
        "languageCode": "fr"
      },
      "reviews": [
        {
          "name": "places/ChIJgWjMZ-md8kcRaVJMoVDvA_o/reviews/Ci9DQUlRQUNvZENodHljRjlvT25kbGRrZEtPRWRMWTJsNGNtNWtZbTlmWmxaNVQzYxAB",
          "relativePublishTimeDescription": "3 months ago",
          "rating": 5,
          "text": {
            "text": "The food is nothing special. The fries were good though.\nThe service was fantastic and the location is ideal.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "The food is nothing special. The fries were good though.\nThe service was fantastic and the location is ideal.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Matthew James",
            "uri": "https://www.google.com/maps/contrib/104083962315939354272/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUiH0czZj2MVgZB5WwrZMsSfgVGk5DviHVF3EIH3YotD2_0QM7Q=s128-c0x00000000-cc-rp-mo-ba4"
          },
          "publishTime": "2025-10-15T13:28:07.779420308Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT25kbGRrZEtPRWRMWTJsNGNtNWtZbTlmWmxaNVQzYxAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT25kbGRrZEtPRWRMWTJsNGNtNWtZbTlmWmxaNVQzYxAB!2m1!1s0x47f29de967cc6881:0xfa03ef50a14c5269",
          "visitDate": {
            "year": 2025,
            "month": 10
          }
        },
        {
          "name": "places/ChIJgWjMZ-md8kcRaVJMoVDvA_o/reviews/ChZDSUhNMG9nS0VJQ0FnSUN4MV9qYVNREAE",
          "relativePublishTimeDescription": "2 years ago",
          "rating": 4,
          "text": {
            "text": "Right in the heart of the city. Great place for a beer lover to chose over 2004 beers from tap. Amazing staff and with easy payment options. A glass of beer roughly cost €5~, yeah I know it's kinda expensive but you can experience the different in house ones if I were you. A walk after those beers into grand place gives you good vibe if you are a tourist",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Right in the heart of the city. Great place for a beer lover to chose over 2004 beers from tap. Amazing staff and with easy payment options. A glass of beer roughly cost €5~, yeah I know it's kinda expensive but you can experience the different in house ones if I were you. A walk after those beers into grand place gives you good vibe if you are a tourist",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "ajith lewis",
            "uri": "https://www.google.com/maps/contrib/113497579647250180657/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXJB6zp7D19HHdf4MeZ1pURIBuA0PzLeVKBJyjHwgHOrUi3HCMamw=s128-c0x00000000-cc-rp-mo-ba4"
          },
          "publishTime": "2023-05-28T08:43:43.903987Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChZDSUhNMG9nS0VJQ0FnSUN4MV9qYVNREAE&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChZDSUhNMG9nS0VJQ0FnSUN4MV9qYVNREAE!2m1!1s0x47f29de967cc6881:0xfa03ef50a14c5269",
          "visitDate": {
            "year": 2023,
            "month": 5
          }
        },
        {
          "name": "places/ChIJgWjMZ-md8kcRaVJMoVDvA_o/reviews/Ci9DQUlRQUNvZENodHljRjlvT2tKaFQzaE5iMjFWV2xCUWRVcElOME5QWXpKMU9YYxAB",
          "relativePublishTimeDescription": "a month ago",
          "rating": 5,
          "text": {
            "text": "staff is fully aware at expert level for the beers. it makes it a good franchise of the original cafe in Brussels.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "staff is fully aware at expert level for the beers. it makes it a good franchise of the original cafe in Brussels.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Tuğfan Aslan",
            "uri": "https://www.google.com/maps/contrib/103045437420057805844/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUTpSvgniCh9bV2i73ykjVqCrNSJLZ8wrvdUD9Le6uGY9yzhdnr=s128-c0x00000000-cc-rp-mo"
          },
          "publishTime": "2025-12-13T10:24:18.897777419Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2tKaFQzaE5iMjFWV2xCUWRVcElOME5QWXpKMU9YYxAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2tKaFQzaE5iMjFWV2xCUWRVcElOME5QWXpKMU9YYxAB!2m1!1s0x47f29de967cc6881:0xfa03ef50a14c5269",
          "visitDate": {
            "year": 2025,
            "month": 12
          }
        },
        {
          "name": "places/ChIJgWjMZ-md8kcRaVJMoVDvA_o/reviews/ChZDSUhNMG9nS0VJQ0FnSUNKcWVuRkVnEAE",
          "relativePublishTimeDescription": "2 years ago",
          "rating": 4,
          "text": {
            "text": "I can’t really comment on the food as I stopped here for a drink. It’s a lovely bar with three floors. The staff were very pleasant and off course they have a great choice of beers to pick from.\nIt was very busy when we were there and I can imagine the three floors would be rammed on a weekend.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "I can’t really comment on the food as I stopped here for a drink. It’s a lovely bar with three floors. The staff were very pleasant and off course they have a great choice of beers to pick from.\nIt was very busy when we were there and I can imagine the three floors would be rammed on a weekend.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Peter S",
            "uri": "https://www.google.com/maps/contrib/108406126283782868302/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWjBOIFASPOol91EVcFvHeauonjA67dy-L7bzA8JaJuzy1Gc_47=s128-c0x00000000-cc-rp-mo-ba5"
          },
          "publishTime": "2023-06-30T06:16:50.153701Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChZDSUhNMG9nS0VJQ0FnSUNKcWVuRkVnEAE&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChZDSUhNMG9nS0VJQ0FnSUNKcWVuRkVnEAE!2m1!1s0x47f29de967cc6881:0xfa03ef50a14c5269",
          "visitDate": {
            "year": 2023,
            "month": 6
          }
        },
        {
          "name": "places/ChIJgWjMZ-md8kcRaVJMoVDvA_o/reviews/ChZDSUhNMG9nS0VJQ0FnSUN4azhIUEdREAE",
          "relativePublishTimeDescription": "2 years ago",
          "rating": 4,
          "text": {
            "text": "Dijon has a cool brunch from Delirium Cafe with a nice mix of Delirium's beers and some local crafts as well.\nThe service is OK and the tables on the outside are charming.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Dijon has a cool brunch from Delirium Cafe with a nice mix of Delirium's beers and some local crafts as well.\nThe service is OK and the tables on the outside are charming.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Douglas Evangelista de Carvalho",
            "uri": "https://www.google.com/maps/contrib/106628199007310019644/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWcKnZvvVKQW_CeuERkf-pF7I9i6LcfQNoR7K8Yw55A9mCEMJiz=s128-c0x00000000-cc-rp-mo-ba6"
          },
          "publishTime": "2023-05-25T08:10:27.398768Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChZDSUhNMG9nS0VJQ0FnSUN4azhIUEdREAE&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChZDSUhNMG9nS0VJQ0FnSUN4azhIUEdREAE!2m1!1s0x47f29de967cc6881:0xfa03ef50a14c5269",
          "visitDate": {
            "year": 2023,
            "month": 4
          }
        }
      ],
      "photos": [
        {
          "name": "places/ChIJgWjMZ-md8kcRaVJMoVDvA_o/photos/AcnlKN2bgMyergRnnuSBU6yP_qmVKlCDnfJalnYlXP07UNHAi2WNFOen6qFlDivEXFluVfYsAf2jHA9XxOpk7PIm3dJYbmUMWs99q_dKv7N_JWAvQLo83c0ZrSoIh74E8d1cJxY3vPT6meThHQppMoLIyJJIsbN-riUAswaxiPR-zOM9B9j-dKJAQV99S6tpys6qSoiJeJ09DVGSzJGWPSCUBEX7GnIL_6FsC2JOF6QCPFoxtlexWn_91HlhgAQr-uZLP_TOCsC2WRAJCgDu7kV50Fmr9-S7_nD2TMJ3EvUERPmHaFR_AL3nQXTGfmMNJGAgJ8X9Za9ta1XF0QOaeY5FmusV9wJi8mrkrA24PU3HlRIZiXOS_-0OulNqtEYhae8EepBDZPnEKUTUwCkebvGsMATXNGHybm9oqVN0DPnsxio",
          "widthPx": 4608,
          "heightPx": 2128,
          "authorAttributions": [
            {
              "displayName": "Guy Pauget",
              "uri": "https://maps.google.com/maps/contrib/101956018669865571780",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocL9_ghy0GNrZckVJQr3IlcXNW1-Px89ckuYSMX_WAD9Jr3neA=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgIDM6MmPeg&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgIDM6MmPeg!2e10!4m2!3m1!1s0x47f29de967cc6881:0xfa03ef50a14c5269"
        },
        {
          "name": "places/ChIJgWjMZ-md8kcRaVJMoVDvA_o/photos/AcnlKN2gr-qP4Dk9xjowdpPER4Sn6H96JMvy-osBoOH-WzrnP5rG1Zpn1Z20DcBOsSEEzAXfJ0Xpyj8JsaP80LNmcA3P5xVQoRxdQqb7muyjD4aBFz9smcK3QO9KeU01y-Hz6onODN_etGTvjFEPS_HWsdAdimj4f-1qSWqtLZCK8sEnVX3dD75n5YWu24U7MHKe8oWXXQF_L972pbXuCaEJRRDgAYDRPjOz1Oe-D29koiiiJbdNVwIhLJyoGYJhOFTEtbLohcM9PiW9hnastzXrBl6NV0JckwXGOfvj0U1zLh08vNnDngdGqDCkiZz-7NV9H6EkgM8PT0pXk8ZMEGtzpRZ8-GArwzylzWMaq4cw8EIp79S5q00YiOvX3ObEk5NkdHiw9D5YiHryqXf-vf3Hf6G-b9dsGZMumPAHk66K3pxbF35WWByZ2NSqDqAjSA",
          "widthPx": 3060,
          "heightPx": 4080,
          "authorAttributions": [
            {
              "displayName": "Julien F",
              "uri": "https://maps.google.com/maps/contrib/107164078033628251557",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWZHvWs72yqWoZqyiKutSxRbtszQ_rQKw4qgIDia2UNVh4X8T5N6w=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhBx9S8XT989MCoHJJtz0EF1&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhBx9S8XT989MCoHJJtz0EF1!2e10!4m2!3m1!1s0x47f29de967cc6881:0xfa03ef50a14c5269"
        },
        {
          "name": "places/ChIJgWjMZ-md8kcRaVJMoVDvA_o/photos/AcnlKN1u3Q40NKhad3_clLjuA1FzppHxxsVXGkjYkWaRGbBJK5HUeOCAawYSwQIpBfKHVzvHRybkAfW--HspxlYtQoRH-1gkhZniM65YH5LJY7HhvMiRJo8YtSYqY2gwobipggS3WLUBPdIe_HDWogYrc_QcIDwXyi_qfPcu3zIJHB1rgxNM6XHoPiUvLJCGGxPeBEscm0RZX2Ms-Ay9HNSmxRTI0ZbzwZDx0G-Ew-9-lKc52Kb_nBivkYLOhyC_S2GH74nqp604GpeUkTx4r33u8dZ_O-_9G71bni1dRp3PqUoRaysqDTJN_OHWpWJxBSkAaTpjcNub-U4X52QEEaUV6SdReAtKlevb2tl9Nl0h8WDmpK60nEe-53hQy47HtJvEHWnzdKdz_ti1qo9aUHZfCJj0l1cg0BdAsq2Cl0-iQjUqFnM",
          "widthPx": 3024,
          "heightPx": 4032,
          "authorAttributions": [
            {
              "displayName": "Guan C",
              "uri": "https://maps.google.com/maps/contrib/117323149965165095455",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUPiLh-3DDXbwPnElAwTiRi0RweyFMTLv3rrnsgR8U2oHoDDQav=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgIDxuO-28QE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgIDxuO-28QE!2e10!4m2!3m1!1s0x47f29de967cc6881:0xfa03ef50a14c5269"
        },
        {
          "name": "places/ChIJgWjMZ-md8kcRaVJMoVDvA_o/photos/AcnlKN1Tb0yuv1rLgOjVDGnn5VfvOf8lNlPnZhcAuR7eqHbVaPfwLZXAX_ESCC9Xz3mP6qu1p3f5BvyWKVj5iutX88Xnunh9yhLoiPUnZV2LkM_Tlz3p0_jzTnJjOPOLLo-y3p05UHxvssLWN6oO_OBgXdapTBY9vmvyvuGEUseigzfSQA_tdnlNJhUc0faeao6FHoqukR08bkZDFhuWhrfjT3O1NeqaqAvv0-PXrKPdQmSasMVlZijE76ebeJ-wvA6dVmbJiUkyF4OSSjgo3aqtw-jp1jVU-zmrRiTUOttYCxaXbN3oIABBEZ7U5qTALd4Vk3QMTPmaJ9FJscDYUe8_ZUo5I8-6k5BtVU6d0UkbKuFYkUG_esDTn1v9Yt3i9nQJ691ZaL-MWJvM7ls2azEwyK3A6-GqE8O_En9CNJzi_RrIHg",
          "widthPx": 3024,
          "heightPx": 3372,
          "authorAttributions": [
            {
              "displayName": "Gaëtan",
              "uri": "https://maps.google.com/maps/contrib/104868231173942037594",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocLWd0tuizwoB3vQJrWPEGj4GgtR6j9asTR8Wt0nnwRZygk-Pg=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgMCg48e8Cw&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgMCg48e8Cw!2e10!4m2!3m1!1s0x47f29de967cc6881:0xfa03ef50a14c5269"
        },
        {
          "name": "places/ChIJgWjMZ-md8kcRaVJMoVDvA_o/photos/AcnlKN2Hh13ySoVS4P01lABAroMWoT2VOfYNG1144d7Vg0Lr7UfsZh5LvMBmNnRIsCFux04JU7lC7vJsom6RnUkxAHy8jOPqj-UIZQfMvDxP95Oa-AISgrU5tPT3-VrE66-wgg7ZpN0PaaiO1tD3UlUjpDHeYgH2cgAb7-ctTMqDo9jJF7KcrBbpQgCKgWJMUlEamOjiHROb9QdLbeilqijXg2DJWQD1a_hfgcCAH2v35V1GeMONuvU7BD5tiVtxoFthV18h_z96cqCs3EmsCqId72HEwCuGseA9Oh5bqu57X7Bx2KiwBUz1iTUpkG_LKRLx1nytqncuFA_vzeVwOijG4ypP0jC1QKuBQUQfmBK-9foaEIzIX4lEyWEozmtjgEbwR_3HOa2E1Di7-DAt7hJAaVd6G1blEG-nQ6Amkibhd5AVTXNwE7uahrtJs3QDcbd0",
          "widthPx": 1902,
          "heightPx": 1737,
          "authorAttributions": [
            {
              "displayName": "Glen Minto",
              "uri": "https://maps.google.com/maps/contrib/108320483234509727278",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXtc2flGfYfwGxQop7Od-5gi3EKKkDTCCOw1h_H1rkZcBmLnA=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhBIdUIWtcsvR_k-tdqW3YsJ&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhBIdUIWtcsvR_k-tdqW3YsJ!2e10!4m2!3m1!1s0x47f29de967cc6881:0xfa03ef50a14c5269"
        },
        {
          "name": "places/ChIJgWjMZ-md8kcRaVJMoVDvA_o/photos/AcnlKN3JyqXUlaZAnmIm59FEsNYMK8aYQqTn0eBdawQzoOq5gOj8z_nuhluyG0BS7Q3bMZghLbct6QI1Q4nzPUwqszQo4qV9tt9XdK55moKYLlZc2-YG0zruKEXN514YFr-cYvJSzKWjIQthFEA2KrJ_FQOHeF7NVsjR1ISJb3polsTpuhWCCOrxUtyRnbOcR-GYcu1_3o_5qPy1d2uAacBsuD2tmBRsaw1z6zowsE2e6IdYYwr4VgBGxJqYdpw5dXk3eOpUNiRbhTEBQ0ouJ7FU_DlzhIpxNEuMUywgUFcdo7mdH35qH3f9X0O4poQlyIQ0CnTOdKtdl5-nCWWMB_KP2QAEiCRm-lVmruW0vYZE5EobBG_ra0KHp1xecMFBmMkhB6yyUh3tSn7MpBCkWJpOvC6isWqAXPGxbi6W02NStvlBTkqohwFkD13gdAYOuCZI",
          "widthPx": 2268,
          "heightPx": 4032,
          "authorAttributions": [
            {
              "displayName": "R2Di2",
              "uri": "https://maps.google.com/maps/contrib/108654592802829720993",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUxKtVU_3EuD_0k6ljvEqo563tsONyfxFT0gbfJQxUk3bBzRBHm=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhCph99_FE72kGGii-_3_j7c&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhCph99_FE72kGGii-_3_j7c!2e10!4m2!3m1!1s0x47f29de967cc6881:0xfa03ef50a14c5269"
        },
        {
          "name": "places/ChIJgWjMZ-md8kcRaVJMoVDvA_o/photos/AcnlKN10RexYhXpw_q3w1Zi4-L9e4hJu5qJCLDx-iI1emj_xdqdPQ6pICX7uGWkTSpmTBlbY8TPR6qjPReSPBHjF9dOxxVZGawheP0qcQetfdZvk_brqdmXvzsQuQstU8nT_FF-bzWqUo1K2IbWKv672JU37_EbjUf6XyXITJyrL6akOzZKSBHJFFKbc7Nwb9zH-GMl3X4RPnpvlRaqJ1URLKDSpdzglMPQMFT_0bT0_RLTxQLruK21cSVKbZJBtNJ1B4hDwHLOFzDb9xs5I1S-C4W2iOymoOls7xL5QlULvD4STR92QYjLIOLxTZxjARiOdvYYqzqQ0WU5PhLADDy3tTY74hUMJBxFWfc-W4r8SoYeGNOi1UblNCfCA2j3HOEEzHf4vYLA9_MDG5tNil3oV5UG4uoyvBXuQoW0qeiPCNF-uvoprB7EehyCLpfeXfYDk",
          "widthPx": 1618,
          "heightPx": 2876,
          "authorAttributions": [
            {
              "displayName": "R2Di2",
              "uri": "https://maps.google.com/maps/contrib/108654592802829720993",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUxKtVU_3EuD_0k6ljvEqo563tsONyfxFT0gbfJQxUk3bBzRBHm=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhCH14IalDQio8NbOb6r3HgS&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhCH14IalDQio8NbOb6r3HgS!2e10!4m2!3m1!1s0x47f29de967cc6881:0xfa03ef50a14c5269"
        },
        {
          "name": "places/ChIJgWjMZ-md8kcRaVJMoVDvA_o/photos/AcnlKN3bej75F4rBL6W2KXJoNIjxUpSmgiUDUpwrVAdXBexaTzFhy1hB95Cp0eyXA7we7sFBy6TFv6_4p293sg8RaTA1BA0OeUTnIqSq3nRkDWTpefJ1yUpRS738NNuoiiEj80roPwvCOqPBQ47_vLfc-FmUHn80l4V4S9NgHvJ0-CLAuuThsY85l6o2zv7Jz7JQ5OybqpDpPfLWWtiG0FXpsIhml1FK7J-c4uxkJiSd7n9JwczieRTbFFKs9QeOWb3heqDKj7Oh1D2jtjc-93EYknqp2UQfnSANeGPQNElotIB3gmuNOja_jZZglNFgoZbS4WNb0cnZ3IJhtWzCG9Zq3Y6PwW7iG0Uw44emr2nBc8pvpiPtyQc7WKu48Z5DZzEr772VJolDVlrYoCdcYpfg4PJbyYVauMR5dGDTH1vLJamBk0mo",
          "widthPx": 3024,
          "heightPx": 4032,
          "authorAttributions": [
            {
              "displayName": "Dieter Anton Berger",
              "uri": "https://maps.google.com/maps/contrib/102120813222234837412",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocKy1bC51zAaudY5JEimCE-9gmxdWFCrYNZjEQx5Xr0iRHMHkg=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgIDuiqGh9wE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgIDuiqGh9wE!2e10!4m2!3m1!1s0x47f29de967cc6881:0xfa03ef50a14c5269"
        },
        {
          "name": "places/ChIJgWjMZ-md8kcRaVJMoVDvA_o/photos/AcnlKN1B_ytPgFVT1gLLTAi0DDpuQRoaYqbgoFLC2vkBXkJLT_ODZTX_1_fW6oQgZaNP6NkPiCHk0VnOythTWClPBFrvDnStSralOk8aLpqvg8rEpfmmAUBDVyCzoI_BmonmPVFWYl-1-_PTsf70FsTC4-oYnlPrpXOrdeH-Iz22n_uxLP-pRrO4gu1F4cfmqv4yzLWuF3SXAKxE5Y1nGdHM0F_nVxiRf5EHMzmmOcrOO9JIyRDdZesp53QO3REBcu-bjI57jlPQZYQD7IiEMKSjfWce8vqUMcnZWngxVsxpeBMDn-flmKdbEGIjO2eyMEwoRBFphO0VcScQuuwONW-QibitmpsTJsuI_R6seM-xWkMPW2xCC6BimyZPBkCeXaMkyBnFXy17nTuAFWzFzYeb5VOGHnltdWrLNNQ_qAEj1q-tne75IFOLSIhItm4on79K",
          "widthPx": 2560,
          "heightPx": 1708,
          "authorAttributions": [
            {
              "displayName": "Guy Pauget",
              "uri": "https://maps.google.com/maps/contrib/114884767210017335836",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocLH7fY9II6Hr7zD0TMRqwwxlHCACr2T0AQHax9F2FyBCVmh3w=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhBX5xQA2TusVa_B-GIS5hJK&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhBX5xQA2TusVa_B-GIS5hJK!2e10!4m2!3m1!1s0x47f29de967cc6881:0xfa03ef50a14c5269"
        },
        {
          "name": "places/ChIJgWjMZ-md8kcRaVJMoVDvA_o/photos/AcnlKN2rJzPTnGPEWKP6HXwuXzc3eiRTefFGv5TQTuP1Am52MioHRNMh7IqACiAsVGo-PQG9dkYSF5mgLUl0zHnzMw-vJtZAzr_-ofg83bGAb0AiEPWHqoYwnEegvaiOiYvKfQpPT5jEfychQyawkbEbqWcG2GLshQpAhc_aD3H7l2WoofMX6P06V7cOV_EwhfUILp-GWWHyQfgPxc1cpHnD5iBXfizcNet52THuQKHv9aT8QJUVJv4CPdY9Le51obD3gjJYx3JX3dmUD0hFCL6Ux5my13VMa_z17YmKIb0uAKqMeBnUOOLJpL5YYnXfh7ENeXtNh23Cr88FcqA3X5CtrZixupdszd-3PKxbdjqJL26rjCO5o_AmmdDL8rpjzRvlGeSOtGiC8QskhjlTMKaBTYDjvcbXWOzUE6J3db8IY35dhA",
          "widthPx": 4640,
          "heightPx": 3472,
          "authorAttributions": [
            {
              "displayName": "Franco Guarnieri",
              "uri": "https://maps.google.com/maps/contrib/107005978803790508010",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocKCCM31RFi2sbNFhlVJFhW7G1XJokn04ZSyKfMpv-rX8BkiXQ=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgIDb0onkJw&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgIDb0onkJw!2e10!4m2!3m1!1s0x47f29de967cc6881:0xfa03ef50a14c5269"
        }
      ]
    },
    {
      "formattedAddress": "2 Pl. Darcy, 21000 Dijon, France",
      "rating": 4.3,
      "userRatingCount": 5866,
      "displayName": {
        "text": "L'Edito Dijon",
        "languageCode": "fr"
      },
      "reviews": [
        {
          "name": "places/ChIJi-v8buud8kcRH6JFU-fvc_k/reviews/Ci9DQUlRQUNvZENodHljRjlvT2tOclpqTTFSa2RSYW5OYWNHTlhUVXBhY21KclowRRAB",
          "relativePublishTimeDescription": "2 months ago",
          "rating": 5,
          "text": {
            "text": "Really great place near the heart of Dijon.  Enjoy a beverage or two while people watching and make a reservation for dinner.  The ambiance is very nice. The service is excellent and the food is top notch!",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Really great place near the heart of Dijon.  Enjoy a beverage or two while people watching and make a reservation for dinner.  The ambiance is very nice. The service is excellent and the food is top notch!",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Ron Thompson",
            "uri": "https://www.google.com/maps/contrib/114789174799769222218/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXRpcjJDSQ1ik3IUSvh1DThOJUx34mLWWXImGz75qbKPN0XsV1a=s128-c0x00000000-cc-rp-mo-ba6"
          },
          "publishTime": "2025-11-11T19:32:34.662011980Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2tOclpqTTFSa2RSYW5OYWNHTlhUVXBhY21KclowRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2tOclpqTTFSa2RSYW5OYWNHTlhUVXBhY21KclowRRAB!2m1!1s0x47f29deb6efceb8b:0xf973efe75345a21f",
          "visitDate": {
            "year": 2025,
            "month": 11
          }
        },
        {
          "name": "places/ChIJi-v8buud8kcRH6JFU-fvc_k/reviews/Ci9DQUlRQUNvZENodHljRjlvT2xkeExUWnlaV3QzVlRsSU16a3lPRVYwVTBFM01rRRAB",
          "relativePublishTimeDescription": "a month ago",
          "rating": 5,
          "text": {
            "text": "We spent a very lovely evening at l’Edito Dijon. We booked online in advance and we were seated at a very nice and quiet corner table. The food was very good (Some of us had local type of food, while one of us a more international dish), all of us loved it!\nThe service was super quick, efficient and friendly and Jonathan made our dinner even more fun. Thanks a lot for the great service, we look forward to coming back!",
            "languageCode": "en"
          },
          "originalText": {
            "text": "We spent a very lovely evening at l’Edito Dijon. We booked online in advance and we were seated at a very nice and quiet corner table. The food was very good (Some of us had local type of food, while one of us a more international dish), all of us loved it!\nThe service was super quick, efficient and friendly and Jonathan made our dinner even more fun. Thanks a lot for the great service, we look forward to coming back!",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Eleonora Palladini",
            "uri": "https://www.google.com/maps/contrib/101709288167811994156/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocJtjVwjacNuqsntyLhKX7knm-I5wdjRR6MVBrWMtQ6NoQ_2_Q=s128-c0x00000000-cc-rp-mo"
          },
          "publishTime": "2025-12-30T15:07:29.626423329Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2xkeExUWnlaV3QzVlRsSU16a3lPRVYwVTBFM01rRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2xkeExUWnlaV3QzVlRsSU16a3lPRVYwVTBFM01rRRAB!2m1!1s0x47f29deb6efceb8b:0xf973efe75345a21f",
          "visitDate": {
            "year": 2025,
            "month": 12
          }
        },
        {
          "name": "places/ChIJi-v8buud8kcRH6JFU-fvc_k/reviews/Ci9DQUlRQUNvZENodHljRjlvT25RMk1HbHhSbU5HZDNselJGbEdOMG8wUkhWdE4yYxAB",
          "relativePublishTimeDescription": "4 months ago",
          "rating": 4,
          "text": {
            "text": "Good, thats open at sundays. They have plenty seats also outside. I think its a chain company. Menu, also in English, is well sorted! I found it easy to order. The staff is friendly and foid came fast. The taste was very good. Quality absolute ok. I had belgium beer, which tasted very good,too. Price is reasonable. I had a good view to the arc outside.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Good, thats open at sundays. They have plenty seats also outside. I think its a chain company. Menu, also in English, is well sorted! I found it easy to order. The staff is friendly and foid came fast. The taste was very good. Quality absolute ok. I had belgium beer, which tasted very good,too. Price is reasonable. I had a good view to the arc outside.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "R. Ant",
            "uri": "https://www.google.com/maps/contrib/100647282829783612135/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocKWSeeRiT3xoVU-uLkXVWS7VGA1LLnH0oJT2cXg7ak7YALwtQ=s128-c0x00000000-cc-rp-mo-ba6"
          },
          "publishTime": "2025-09-15T18:58:16.481057052Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT25RMk1HbHhSbU5HZDNselJGbEdOMG8wUkhWdE4yYxAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT25RMk1HbHhSbU5HZDNselJGbEdOMG8wUkhWdE4yYxAB!2m1!1s0x47f29deb6efceb8b:0xf973efe75345a21f",
          "visitDate": {
            "year": 2025,
            "month": 9
          }
        },
        {
          "name": "places/ChIJi-v8buud8kcRH6JFU-fvc_k/reviews/Ci9DQUlRQUNvZENodHljRjlvT2xGVlNWQnVUM0ZEUmpWeE5tcE1kbEl4VkdSTVVXYxAB",
          "relativePublishTimeDescription": "4 months ago",
          "rating": 5,
          "text": {
            "text": "Love this place in Dijon. Loads of atmosphere day or night. They serve lunch time specials that are very good value plus anything from the extensive menu. Always busy so be prepared to wait for a table. The staff are friendly and helpful, which was good for us as unfortunately we don't speak French. Would recommend.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Love this place in Dijon. Loads of atmosphere day or night. They serve lunch time specials that are very good value plus anything from the extensive menu. Always busy so be prepared to wait for a table. The staff are friendly and helpful, which was good for us as unfortunately we don't speak French. Would recommend.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Jacqueline Beardsmore",
            "uri": "https://www.google.com/maps/contrib/102822978622075236261/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocL1viEOX2UoBR0k7eCidGxvTEwZoJDeSm7pjvXFqfmfzy5uhw=s128-c0x00000000-cc-rp-mo-ba4"
          },
          "publishTime": "2025-09-28T11:24:05.020438379Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2xGVlNWQnVUM0ZEUmpWeE5tcE1kbEl4VkdSTVVXYxAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2xGVlNWQnVUM0ZEUmpWeE5tcE1kbEl4VkdSTVVXYxAB!2m1!1s0x47f29deb6efceb8b:0xf973efe75345a21f",
          "visitDate": {
            "year": 2025,
            "month": 9
          }
        },
        {
          "name": "places/ChIJi-v8buud8kcRH6JFU-fvc_k/reviews/Ci9DQUlRQUNvZENodHljRjlvT20xMWVHSldUVVpMT1dORFMwOUJkRmxvYkZsSWMwRRAB",
          "relativePublishTimeDescription": "4 months ago",
          "rating": 5,
          "text": {
            "text": "The \"american-style\" pork ribs, were not what I  expected, but were absolutely delicious! Best meal I had in Dijon",
            "languageCode": "en"
          },
          "originalText": {
            "text": "The \"american-style\" pork ribs, were not what I  expected, but were absolutely delicious! Best meal I had in Dijon",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "thenesiag",
            "uri": "https://www.google.com/maps/contrib/110782883803169420573/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjV1N17CVxvaPuHlPJq79aTgTogSViGDq6wJIJqUeABsQthSTjKh=s128-c0x00000000-cc-rp-mo-ba3"
          },
          "publishTime": "2025-09-16T14:37:22.639554065Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT20xMWVHSldUVVpMT1dORFMwOUJkRmxvYkZsSWMwRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT20xMWVHSldUVVpMT1dORFMwOUJkRmxvYkZsSWMwRRAB!2m1!1s0x47f29deb6efceb8b:0xf973efe75345a21f",
          "visitDate": {
            "year": 2025,
            "month": 9
          }
        }
      ],
      "photos": [
        {
          "name": "places/ChIJi-v8buud8kcRH6JFU-fvc_k/photos/AcnlKN3dLkis4PzoxEGp9QblGI_HKDJ66S9fmwczZb095LO38qPP-LAqYCP-lyFbJsNBkvnfV_ibnzv1A6BcYVXwsfM0sfdpCQ7RSLgc7XGrgzttbdkFTNl27F6tTufX5y5UyuQU7rVy64oXCwsZ7Wu3c3wwTYFC2GrYOoNYSt6OWlcVYifK-MqrZlWCEdCWL7_9zCzVFkwTi97jYMQj1aV3YScDls2aG18EKAX39Tmw_2lMHlEYb1HKPyOGQ-rc1uMG3IXAzR3MJjoXGByaUtsJXY9PfssEbLcZXyPrsZzZM9SSaQ",
          "widthPx": 4800,
          "heightPx": 3201,
          "authorAttributions": [
            {
              "displayName": "L'Edito Dijon",
              "uri": "https://maps.google.com/maps/contrib/114786342926825528312",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUxyo8urNdTWoVn6Km5tNBdPpptY0u_SacJy88Ssdr7AXLrOAM=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipP_NlnKi75Tv1uwH3R8m41WKubrF_85rI5K1_RU&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipP_NlnKi75Tv1uwH3R8m41WKubrF_85rI5K1_RU!2e10!4m2!3m1!1s0x47f29deb6efceb8b:0xf973efe75345a21f"
        },
        {
          "name": "places/ChIJi-v8buud8kcRH6JFU-fvc_k/photos/AcnlKN2EJdarizPFQOFY3TQuRBJ9S3suv6dFodEXWWUGYO2vemxiVzBbllRpkWXYNKNsOts74Zad99dAaJB6yiclwu2L-TrTljD6p1kp1Vjm0fDNjCXyaUjHQ5kXUar3OIdT8CvYEKWs80X0HQgeHmb3fadXrfZdt3wWWrNdGjLjuxGNAtinHbpKTEJFCLA5VME8Qt3E_o4ewzKh1iKjTh1eJHb2dekVZ0itxtWWJXbf67o3WNJDXrZeuWO2rNeVskSiUxkI9LyHJIKtoHn17leiRQ7yHUbhtBNgE2FfspV5_ZWoqg",
          "widthPx": 851,
          "heightPx": 315,
          "authorAttributions": [
            {
              "displayName": "L'Edito Dijon",
              "uri": "https://maps.google.com/maps/contrib/114786342926825528312",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUxyo8urNdTWoVn6Km5tNBdPpptY0u_SacJy88Ssdr7AXLrOAM=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipMzMcdZgWdMth_zhjx2Kn79tZKTNJLLd-FGMscP&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipMzMcdZgWdMth_zhjx2Kn79tZKTNJLLd-FGMscP!2e10!4m2!3m1!1s0x47f29deb6efceb8b:0xf973efe75345a21f"
        },
        {
          "name": "places/ChIJi-v8buud8kcRH6JFU-fvc_k/photos/AcnlKN3tXbc8bxnhoutMLVqdLix_lR11Uf5NFcOULRQf5wF_OVjRk5liqZFdY5xA2VAhMt71_zrJKvPzMTXlPOM8Uftw5TTdc6f1TYHxpNjH_DG_Adgz8-XEJ3B8tZyFoj-taojv4ojGChl0QsNg-bYUSCZ8yYOsM4VjYaCwiX8nRx5uDsMVn_U4x8uf0X4X9Jv5qfEfOvn5KNV7rq0r_qPIwY9CoLXk08ZeYan70WtxBSdGQ9mBjW0MwkJd3DVLSrZEsfb7MvOaypLg32jyb0EivTTUcEj1_oORMR6l1sJ1bLBhDKRDlyPzZaxKEY6xEbuhCiTt1zLv81n9ZGmycxSp1CHK0ArHwqq_Hmj-EXDwCUhXzjf9TQiZRMsRw71h2JAPs-h6P-DGKL82-fAB_gW8EAjnsRuLcwQvxDHrMnfwgosxwWKJRJOGHTHJSV-SgXdd",
          "widthPx": 3889,
          "heightPx": 2635,
          "authorAttributions": [
            {
              "displayName": "R. Urban",
              "uri": "https://maps.google.com/maps/contrib/107753843555880882055",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUByVmLNy68Xkic5YZlGVJZjmtlozNW4PolOp42HUHIFFn3NReN=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhDIWU0uHIU5w3HRWCTEEoDn&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhDIWU0uHIU5w3HRWCTEEoDn!2e10!4m2!3m1!1s0x47f29deb6efceb8b:0xf973efe75345a21f"
        },
        {
          "name": "places/ChIJi-v8buud8kcRH6JFU-fvc_k/photos/AcnlKN1dGzOb9udGz_0OGW4KsmZEO6EMH3sMLYuVP8m5EKGKNGFp8BjGhHYE_BDPOoeirREOh1HqjpfJHlWOaMplxw8SEAM22liGZszLbapR-rh0kRaD_B8jjQ-1_gWzEkAq1N3Xv9ymIVNMIeynuFCeIO-OUMvqRDIRuMYT1SreUzFV_zGYbawgBF6d0hHAnbd58uj21hfvQ6c0kXf_GVAjCeta8QCtwcPNvtW-QFdMc7rckX-qKpNdxigK7JK701i0OcJ-D-JDdKD2Oiz45Ir4RE7RYOaB1JnzxBXZ_rzj63pFxyi8WIk63lSAsgz0ZeTUFn0RfWFpkbxWVIyJHNqVy1ObHSpWfQOOpkBPUUI46Sygfrb9YDO1cYD5A9ggIIq2xEMkvfTRHfuM1Dsv94o4Y9uyfUroWZMii2PKXP2YWrqJ3H-GyxXG5iYXHCSPgkXB",
          "widthPx": 4080,
          "heightPx": 3060,
          "authorAttributions": [
            {
              "displayName": "Christopher Prêtre",
              "uri": "https://maps.google.com/maps/contrib/118137768609962964592",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocJsfFsaQOnWyk81ljMhiuX0-B8Zo-k8jroxg3m1JZkYBg3L6w=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhDSmcEVXddDlMzRne1BVs-Z&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhDSmcEVXddDlMzRne1BVs-Z!2e10!4m2!3m1!1s0x47f29deb6efceb8b:0xf973efe75345a21f"
        },
        {
          "name": "places/ChIJi-v8buud8kcRH6JFU-fvc_k/photos/AcnlKN2axNeKdfNSVVa1mQUad4cx4ytMoCpUFxQ7u4eGuvVqQfgvIeuhsQuKvOM75xRFnmyxZwNT72BZqWUxC_c4W_JCjsYNl7kyYtm_DLOuSSqWw3AdkUkBd91mR9_VpFeV0jcyqhyhyiVxrXyKCTa0epQe6ijYVsrVs-zZZDcKUmGu-SFMLUytqeRvsuguynng1txOs26fredageEL_e8D_H8HfEOdD6GYLg84yRRQtGyt4zfN1v3f9LzHzgGz8skfExqFNh3xGgRUQDdVGEQnlHHxcPTNJcJmRjCenD7B8t7GKRnS_LF80Swk9QOLcabPt60Ym8g61cWvbYncvtafNDq5P2WZBI0OhVvd6bKfzh5MC5cN-ebsFNmdzMhLal_8F9CFxCMvUMoPatnK8C0-bTgMhxTfIMb-gag3gTznVHxrsNRU--JOAdBK-t4rXFSh",
          "widthPx": 4032,
          "heightPx": 2268,
          "authorAttributions": [
            {
              "displayName": "Nicolas Bonvin",
              "uri": "https://maps.google.com/maps/contrib/100574278006941297852",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVt6ZLS_TsVZUsiDv2F_RtT-C8iPHLbbhuZHiPXUJi7clIAU53N=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhD6VjNWv5rHeirrEwW6JKnc&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhD6VjNWv5rHeirrEwW6JKnc!2e10!4m2!3m1!1s0x47f29deb6efceb8b:0xf973efe75345a21f"
        },
        {
          "name": "places/ChIJi-v8buud8kcRH6JFU-fvc_k/photos/AcnlKN1ARI9rWzzoHE687vGVgtyttIB9jFjX6Wm_YiFoGMaGl_Ha-Qd5q3u_kc7AWt7_LQlL65Ao2jIZOF8j-rdE7JkFkrwgXppmsTyqMX5MX2-VWpCta6mPkT12u2arJSGzxJ3Loxi2Kbb9OsI6uTXdI56xQfYZrTyio9fEj_KIsV6ifHCzpXgaIsOKdOL_sH7RvRV2woPec_TOOAtDCQo2rEFmlyWVJBWoLqjkKC6zGjMcMmeOH7Y7P3hLJgabN8yQBUZ6Hv6VIGg6TcBz46b9dXrbU478FWUIaFDD8EzZASa1l05MYKfk-lbaO6nNNvxon44wZZy24Nvic1C5P6Tn9aO0TT7uVObDvoUC6jQwIooMZAG-QVYx6lS2AF68UwIgPmDr3S6-QtIcrA_nj_V_CqO47ZD2okC-y5WZA9jqABtaou2j",
          "widthPx": 4800,
          "heightPx": 3600,
          "authorAttributions": [
            {
              "displayName": "max banks",
              "uri": "https://maps.google.com/maps/contrib/114070211082880603480",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocJMIS97MDRbAMPqyRFUY6yaamtbey4lJ_yV9UJb1ADSB157CA=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgMDIqPX19QE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgMDIqPX19QE!2e10!4m2!3m1!1s0x47f29deb6efceb8b:0xf973efe75345a21f"
        },
        {
          "name": "places/ChIJi-v8buud8kcRH6JFU-fvc_k/photos/AcnlKN1EW9vbt86aHk5ZdbDB29GahjDxXk3Oe9GIIbZ_gwCS9iqMp7yE1PHPc5KVwt0wtb2ZiNRg14d63Nuk1E93RnoFOVS0TCI94wsNz6nVm9LSkOxzHsO9GOUBkAqboOikDXVgafSIV6hrHHuR-tPNsADOd-MtTZxuP4hFvDzgUav3Kc-KVweF43wxc7GD2fmpW-RNQaanbFh6fP3z19H0aP5UAlULCBXjUNjOWRvTPGJLrcGbr5-NkQc04bNk6SfQLN5lCrmoWHOH1P_ImKrhbKw1C0EPaythl6WamhF1qF7VKGNUyumP4gdWNLcFQq4dbcscC_ZISx5XhYcYgzlR7haiQgeQA5crJmIxmZvKYB4GIw4kmBVBi4ahBnzto5_HP_IbZs9SvsxGdWT1SDlSgNdQYT3ZV1uUuKvJKchN9iLks4Vty15S-ESOgoadjcWw",
          "widthPx": 3024,
          "heightPx": 4032,
          "authorAttributions": [
            {
              "displayName": "Timo Franke",
              "uri": "https://maps.google.com/maps/contrib/109342787225581097264",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocKI5B0Fel56McZTIbw448G5Eu4XNU49PXyuWEl0d6ITsSqumg=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhD0ulxIZs8i53q8xkkyKreA&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhD0ulxIZs8i53q8xkkyKreA!2e10!4m2!3m1!1s0x47f29deb6efceb8b:0xf973efe75345a21f"
        },
        {
          "name": "places/ChIJi-v8buud8kcRH6JFU-fvc_k/photos/AcnlKN02TDz_12Pvf_OzpKhAhdzzzQITT_EQ9fAN8dnancvnnN9K1Dy-N_9P51vkhMSpt6VReJ0kgqQjSopL6v4Do4PZV3gGG_GsyUbvZKUYjKqWnE8-6jo4y5oz9I1m_s4UE0ER0_qIIwxriZTc-2NzX7QW62KpyLxAh3EuRZsSabEe_6jM-CTd2e4cTiFUe1Mlg_RoE5ehVw35k7-3vo0YNUlfYBxCCNdrxAIkggK1kGE1APHKqIGZsNNRo3jSC1QuvsGtWHOWoHL1fcW_udVYYFXWDC6zv6xlgbo7JrfjM3oviVPmOF4ZYpn5A9YFgmfhnkOVxuX_psj3ZVawu4wmJCrEn_NbKL4Md640u_Wx8cFwEredSzzapeP_u0HIdHMhjfnB2V25ZLK92vC7ZwbiAaLJsyDsRL7qRbW5q1gJYZDVWpGUS9gD4zyzfQpxcUdd",
          "widthPx": 3024,
          "heightPx": 4032,
          "authorAttributions": [
            {
              "displayName": "Johan Michel",
              "uri": "https://maps.google.com/maps/contrib/106067554909840376486",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocKldlVrCCHTIFoDabhKbtkDsHiIS2EohLsV8N_tSgyOUMMuEg=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhA-RSf_s4RMZqXbWJHpSgnP&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhA-RSf_s4RMZqXbWJHpSgnP!2e10!4m2!3m1!1s0x47f29deb6efceb8b:0xf973efe75345a21f"
        },
        {
          "name": "places/ChIJi-v8buud8kcRH6JFU-fvc_k/photos/AcnlKN26K0TIwZYLr6OiAqCmUud-hJqPNtX_2JTWvU4L_-zuPK-4fc_eMca69Q4Dmp8-Z0rWpcu3MXJ21AFM8QxQlSNFGrVnzx5-O5Pg9opkMGdvWX0hBVgad4hf_hxIEpQGqO0w4SedCx0NXOsensuuxXPY2PlegEqPLXxbzDFA1OKLMxAw3BtQJk-DgIeqNbZ8lgMrqRTCo0aqQwMi-O-7D3IvsqvXP0Kb91_ac5OzgoghAU3Rrk-a-M79wSFwwLe1qEPND9yf8uBTE02n9067cEFc4GM0VVWZE3OpTgf6n488qTh3ijOWusdYZB004GxjFR9RpvJQ1CkUxMmpBR6S-dBm7IUubkOjFl-HtCP2xcKUkNkzKvhsB-TY3T8X75HyqumHppZqpp_2hYkgKBWFuWlEgaVF70zQuLzmh4x4sJnJhJcpSqhK00fYLXHIADj1",
          "widthPx": 4000,
          "heightPx": 3000,
          "authorAttributions": [
            {
              "displayName": "Soraya Zeudmi Sahraoui",
              "uri": "https://maps.google.com/maps/contrib/112997677625350704341",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocIFSWVWobk2wIi-dIPlo7_Ge0CzEjAZXbE8S0AZHIcr0ZeaLA=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhB0ObosDUcL0YXdNdDi5e-M&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhB0ObosDUcL0YXdNdDi5e-M!2e10!4m2!3m1!1s0x47f29deb6efceb8b:0xf973efe75345a21f"
        },
        {
          "name": "places/ChIJi-v8buud8kcRH6JFU-fvc_k/photos/AcnlKN1E325TdD17fuxGZfTt93y_1SQE0UrdVopyIMtBCaN6BCQeI4wSBULyzxXL7yttCWkyqvOBG6dxNw_HDG52tRNDuiGoxFUNA0CvBgxfN1hYogTnV-cwhCvS1T5RNkw3Jf1ciRTZ7tmyuFFjL65DDae6OaAShXsWwRNN3NFP4fi2jZ8e9IeQ_VzDvRMRawvuqs8bygGkAKwTR9NGGjm0UeUAPvwo89Cdh1xxYLNOOu6xTFzo1v5jB7mVedZcxcNsgpo-dKrYc2V2chtEs_KrpuAPL06W6Kevhc_Gh0SQvRv6-76ZRmL9Xfs-cFQVyX4wmJWi0QxxBKGB-0n9VTTczEOkqd_yyqoft4mvPfWHJhW1-vy7e3gHiqN0RMXO73rQEmy4QNA7XKmE2s29I4Ooh3q0vskNLSqLHZzfk7ExkDutBf6wEu5Rx7XLNEu4tFtz",
          "widthPx": 3000,
          "heightPx": 4000,
          "authorAttributions": [
            {
              "displayName": "Ron Thompson",
              "uri": "https://maps.google.com/maps/contrib/114789174799769222218",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXRpcjJDSQ1ik3IUSvh1DThOJUx34mLWWXImGz75qbKPN0XsV1a=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhA-Iwaxu7yVzggvj4l1e3af&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhA-Iwaxu7yVzggvj4l1e3af!2e10!4m2!3m1!1s0x47f29deb6efceb8b:0xf973efe75345a21f"
        }
      ]
    },
    {
      "formattedAddress": "79 Rue Chabot Charny, 21000 Dijon, France",
      "rating": 3.6,
      "userRatingCount": 188,
      "displayName": {
        "text": "Carrefour Express",
        "languageCode": "fr"
      },
      "reviews": [
        {
          "name": "places/ChIJq6qmNN2d8kcR4Ljea8Sk3ZM/reviews/ChZDSUhNMG9nS0VJQ0FnSUMwZy1UVmNBEAE",
          "relativePublishTimeDescription": "6 years ago",
          "rating": 4,
          "text": {
            "text": "Essential location if you’re looking for provisions on Sunday afternoon or evening, when it stays open till 9 pm. Jam packed with food and drink but vey small, so the choice is limited. We bought enough for an evening meal, with a decent wine, and breakfast. Please note - the (very tasty) baguettes are behind the cashiers.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Essential location if you’re looking for provisions on Sunday afternoon or evening, when it stays open till 9 pm. Jam packed with food and drink but vey small, so the choice is limited. We bought enough for an evening meal, with a decent wine, and breakfast. Please note - the (very tasty) baguettes are behind the cashiers.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "The Aardvark Arrives",
            "uri": "https://www.google.com/maps/contrib/108679911826812405703/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocIaPBMEBNHvV_1AwdZI7_NtArexhTgWVlojL010JeKb1Q7ESQ=s128-c0x00000000-cc-rp-mo-ba5"
          },
          "publishTime": "2019-10-08T08:14:41.598522Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChZDSUhNMG9nS0VJQ0FnSUMwZy1UVmNBEAE&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChZDSUhNMG9nS0VJQ0FnSUMwZy1UVmNBEAE!2m1!1s0x47f29ddd34a6aaab:0x93dda4c46bdeb8e0"
        },
        {
          "name": "places/ChIJq6qmNN2d8kcR4Ljea8Sk3ZM/reviews/ChdDSUhNMG9nS0VJQ0FnSUMweVlLcTF3RRAB",
          "relativePublishTimeDescription": "6 years ago",
          "rating": 5,
          "text": {
            "text": "Nice little store. Good selections, clean and well stocked. Polite and helpful staff.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Nice little store. Good selections, clean and well stocked. Polite and helpful staff.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Tiggers Travels Site - Overland world travellers.",
            "uri": "https://www.google.com/maps/contrib/100148998634670928399/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjW_Pd9VRMbHJ-wNtCKkK34aGd8UfSccrLa9pitm3tbXi6PmzEE=s128-c0x00000000-cc-rp-mo-ba4"
          },
          "publishTime": "2019-10-01T16:32:23.349744Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChdDSUhNMG9nS0VJQ0FnSUMweVlLcTF3RRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChdDSUhNMG9nS0VJQ0FnSUMweVlLcTF3RRAB!2m1!1s0x47f29ddd34a6aaab:0x93dda4c46bdeb8e0",
          "visitDate": {
            "year": 2019,
            "month": 10
          }
        },
        {
          "name": "places/ChIJq6qmNN2d8kcR4Ljea8Sk3ZM/reviews/ChZDSUhNMG9nS0VJQ0FnSUN3NjRfZFNnEAE",
          "relativePublishTimeDescription": "7 years ago",
          "rating": 3,
          "text": {
            "text": "May come useful if you're in a stringent need. It provides basic stuff at slightly higher prices than the   mall/shopping centre.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "May come useful if you're in a stringent need. It provides basic stuff at slightly higher prices than the   mall/shopping centre.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Ciprian C",
            "uri": "https://www.google.com/maps/contrib/109189630920711860129/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocJ60pmzXzCOPsT7DMdxsUUC9HqfTyLMFTcM07zFUQ4M0V-p1A=s128-c0x00000000-cc-rp-mo-ba4"
          },
          "publishTime": "2018-07-14T07:35:14.316Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChZDSUhNMG9nS0VJQ0FnSUN3NjRfZFNnEAE&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChZDSUhNMG9nS0VJQ0FnSUN3NjRfZFNnEAE!2m1!1s0x47f29ddd34a6aaab:0x93dda4c46bdeb8e0"
        },
        {
          "name": "places/ChIJq6qmNN2d8kcR4Ljea8Sk3ZM/reviews/Ci9DQUlRQUNvZENodHljRjlvT2kxdFFtMURVV1phT0dkS1pqbG9hRkl6VVhndFlWRRAB",
          "relativePublishTimeDescription": "6 months ago",
          "rating": 5,
          "text": {
            "text": "Friendly and quick. The staff are generally pleasant, although most are summer workers and therefore change frequently. Perfect for a drink/snack with a very good selection or for last-minute items (coffee, etc.).",
            "languageCode": "en-US"
          },
          "originalText": {
            "text": "Sympa et rapide. Staff généralement agréable bien qu'étant majoritairement des jobs d'été, ils changent souvent. Parfait pour prendre une boisson/snacks avec de très bon choix ou pour des produits de dernière minute (café, etc)",
            "languageCode": "fr"
          },
          "authorAttribution": {
            "displayName": "Elio Roy",
            "uri": "https://www.google.com/maps/contrib/107500462287123390533/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUBlPP5DNDGV4vs4bdikgxZ9WWHS1Qi-pdJRlD3XUxuLgi5OUU=s128-c0x00000000-cc-rp-mo-ba2"
          },
          "publishTime": "2025-08-05T12:33:20.833624391Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2kxdFFtMURVV1phT0dkS1pqbG9hRkl6VVhndFlWRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2kxdFFtMURVV1phT0dkS1pqbG9hRkl6VVhndFlWRRAB!2m1!1s0x47f29ddd34a6aaab:0x93dda4c46bdeb8e0",
          "visitDate": {
            "year": 2025,
            "month": 8
          }
        },
        {
          "name": "places/ChIJq6qmNN2d8kcR4Ljea8Sk3ZM/reviews/Ci9DQUlRQUNvZENodHljRjlvT25BelFuVkdTWGRhVFZWQ2MzcElVVE5XV0UxdGNHYxAB",
          "relativePublishTimeDescription": "a month ago",
          "rating": 5,
          "text": {
            "text": "I was greeted with enthusiasm and a smile, and the service at the checkout was impeccable. Excellent customer service from Ms. Erica.",
            "languageCode": "en-US"
          },
          "originalText": {
            "text": "J’ai été reçu avec enthousiasme et le sourire, le service en caisse était nickel.\nSuper contact Client de la part de Madame Erica.",
            "languageCode": "fr"
          },
          "authorAttribution": {
            "displayName": "ngassaki sublime",
            "uri": "https://www.google.com/maps/contrib/116787497266259120350/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUgtOwxDdgqydI1e1LVO6_RhfmOnI0lO_7mPXe7-Ga4Fho7Z4KD=s128-c0x00000000-cc-rp-mo"
          },
          "publishTime": "2025-12-31T15:02:09.667462811Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT25BelFuVkdTWGRhVFZWQ2MzcElVVE5XV0UxdGNHYxAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT25BelFuVkdTWGRhVFZWQ2MzcElVVE5XV0UxdGNHYxAB!2m1!1s0x47f29ddd34a6aaab:0x93dda4c46bdeb8e0",
          "visitDate": {
            "year": 2025,
            "month": 12
          }
        }
      ],
      "photos": [
        {
          "name": "places/ChIJq6qmNN2d8kcR4Ljea8Sk3ZM/photos/AcnlKN2mOIyzelyXS4_-4Xw7d8TR1jhbs-K2IQPsU0uRLWoW6Kg7fGfSw3eVGcckXZg3YOnJttbAuj1FkhPp_kZ41D70Ykm084OsQci4kPpg_g9jl8ap2bET_u9_Sap3oEm87qKsk0Lv4aTq5ZhikFfIzrET97kZpmyjqfO8nV7a5gdEgA-eEMAzfAOTkTMorJiCm2Zf_S5BLriQy3H4i-OuOacdn6XI0BIRYsDs-snXrpQ347mtE9pRmxC9htFCA1yRkSZ0_bAKTUvpooqKF0xTCY__MljmKvHIyxtLP8enSMn0_VyNGk-7seLa1ufv4yeVV3-mSLo2ObMggl9QI42DeMBHD8UATF3null3YH4M1_j4pS8aipnDIo5wxW1BE9os1hNdDYLqVJ8fKOqshIFFPEd_2ASQk-_kU_SqywOG9Q907724",
          "widthPx": 1920,
          "heightPx": 1440,
          "authorAttributions": [
            {
              "displayName": "Edouard Levrey",
              "uri": "https://maps.google.com/maps/contrib/107226135596290876014",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocKYGZqvwVEbdZL3_0ZzYEnJyTwY7b5BpPqigrKEzGMoDvzfLg=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgICE9o_68gE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgICE9o_68gE!2e10!4m2!3m1!1s0x47f29ddd34a6aaab:0x93dda4c46bdeb8e0"
        },
        {
          "name": "places/ChIJq6qmNN2d8kcR4Ljea8Sk3ZM/photos/AcnlKN0WxoiwzT7WhlBOBHu5wJzGfsi0pU37F6Jol9SIvyS95JDnB2RO4DYTSTlo8qDOYL5960znkNKa3dCxFSojLszfJ5nB5uXGQUFp_4VfQoLSJKJzFp8w2NF5jGl7m7IeUISAXIvGD2S4D-SGwknnkhXtTphNqxFdsT5Y7_s_mK6fDPzh8EhFX1ev3lRmezUiMS9lF9ujKpu59E_UbpcuXpXXgffoBFlqwc1_33SN1mrUQ_0jDIPbu633MLzFt9OLa3kb94BxYpYBJHIyjDOohNcKGNJo-X_kxyWADSWQER55gg",
          "widthPx": 480,
          "heightPx": 270,
          "authorAttributions": [
            {
              "displayName": "Carrefour Express",
              "uri": "https://maps.google.com/maps/contrib/109352732781472759900",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVUj88-kj91qT4QXISfGLkMTdwYBJqcIBW2JDagGXrW0D-0z65C=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipPLyoP9RZ5GrSHMLy4KvlQiPpmHOGwT6fHajvxb&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipPLyoP9RZ5GrSHMLy4KvlQiPpmHOGwT6fHajvxb!2e10!4m2!3m1!1s0x47f29ddd34a6aaab:0x93dda4c46bdeb8e0"
        },
        {
          "name": "places/ChIJq6qmNN2d8kcR4Ljea8Sk3ZM/photos/AcnlKN20YchGOWTtSFlhGhhgM3m7YvIMD9SfHtT3zSycZnM9iiWYIIJfIgn54LxWxj5vMbIXD3V6xwzFJjIRnQVyCYZWGqdL2zEooZp0uJIf3L3TGcbXT6mShSE0jKIEmB9ie2JBrBL3fX5AT6xjr_5SjzfPE90aeYmur5jKSbqH-X-EK7Eq8e2LYQ3_AnWTuBshgb7LpeStzbyEcmi3S2_ydVIhKVKo5HDGKZUVI9BzU_pz8bdfB0_jN2b_GFnm1sSMAM4Jpzad7E-wh4Y9u27vH4e514M9_vAo7hFL8uAtOFmyZl0wNKNt-RmyNJ1puyufPThIS5mz5tzG7ZA5IIYI5Y7elHtI5XFxEGpnE46qnMkFgfELnLb_cErRnsK1JaMdM1JdcLxg7HoxED9M1LvWs-KmsDoPs4201O7y0agXArODSA",
          "widthPx": 4624,
          "heightPx": 3472,
          "authorAttributions": [
            {
              "displayName": "Vladyslav Ponomarenko",
              "uri": "https://maps.google.com/maps/contrib/100454431384131641521",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUW71T3zZ2yi3E-xFj74DsW05Z-CdWg4AuKuaI4dPfGoKqYuJ01=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgIC7xIiqGA&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgIC7xIiqGA!2e10!4m2!3m1!1s0x47f29ddd34a6aaab:0x93dda4c46bdeb8e0"
        },
        {
          "name": "places/ChIJq6qmNN2d8kcR4Ljea8Sk3ZM/photos/AcnlKN1rDoOxMimYoa_HsxncWV9QAs_iQRzW-WoyWhJKZD1OOP9j2VF09_75c3ZRDcxKBE5WLDQl5S-AQr0v3p-1P5myjgB3d-_AkJWrhoh70H_fQZTYwzgrxgSCMuKst4wltYBzPJ1WsV8gpD9tQZi-ciylxF7S5N-DBBb2VFeb4_KFBWBjAXh3nXU64G6EbOUqSOvm0ZucHGp3GnvCvzZCotsSSOt-3rIzy-qrx-3bh6bfOD-8Wd8m_KRGgNxG9m1rbMMQzQmEGQOhwTR8J5egEHiuBqPve88F3WbpLmax_gY-PA",
          "widthPx": 1600,
          "heightPx": 720,
          "authorAttributions": [
            {
              "displayName": "Carrefour Express",
              "uri": "https://maps.google.com/maps/contrib/109352732781472759900",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVUj88-kj91qT4QXISfGLkMTdwYBJqcIBW2JDagGXrW0D-0z65C=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipP2chZq7BHa3zHziUgvYOGpe7klIbbpxvayrZUU&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipP2chZq7BHa3zHziUgvYOGpe7klIbbpxvayrZUU!2e10!4m2!3m1!1s0x47f29ddd34a6aaab:0x93dda4c46bdeb8e0"
        },
        {
          "name": "places/ChIJq6qmNN2d8kcR4Ljea8Sk3ZM/photos/AcnlKN0_IqV87iiOuQb9OYfrvtNUqoaKYnGgJi9x0ww30DzabwcjoLDZiECqdYfAn232w-SUpvsKZv_NoBJ0AQ8LvZquMM8MVOwANf-4RLyTh-dKCzxUW8_gEmryny69z6hdSme4RxLwcQm28iItFVyzftDgXbveeBr8Ddcmu6sSBQgg_yvls2g1RqgJWI4yKNloctvUeS0EVcCg-usvlY9qyFGync8sQYR-wlUOb__Prz8MGMNBnowcVg6Uw2qGsfp9cpz5LLzMaHXSZVr0bP35LUbtCJQE81LavUOkr0NL17bWG-PX3YgK42xhCtT2SWfZ7mwVArbwY9wBxdgbH3DxbNz5WtWbAGoqJFfcsU1Ew4PmoFi5HlgA-wM-jrdLkOHGfDLPFwxQSszQz3IL0HF8myvjXjAjqDarncTBJpgnsszFJsOLAYhhkGvATB6Eow",
          "widthPx": 4032,
          "heightPx": 3024,
          "authorAttributions": [
            {
              "displayName": "Brigitte H",
              "uri": "https://maps.google.com/maps/contrib/116718266896651886950",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUrGHkGwGjdzKj5NatrCryIwyYdGN-KJVX-QrbgNXSe9UIRmxmV=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhCaEIbWL6JUIF9683iEroIc&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhCaEIbWL6JUIF9683iEroIc!2e10!4m2!3m1!1s0x47f29ddd34a6aaab:0x93dda4c46bdeb8e0"
        },
        {
          "name": "places/ChIJq6qmNN2d8kcR4Ljea8Sk3ZM/photos/AcnlKN318pmwys7jiQgrkH1-zBbeWpZp1rIaQis4TzIWeVvsevPYiX40YR1Hn0-neA-GVYfLftu1793OKG7PlsuhdijGf-ULZmYQRtaIvpUnwwb4_qzjkkLkijmZpatV8txwMYsuweu9Z8PSi-_xBrsVcvet1JyjzS_VZqupDHhI-4hNSTnXUCd26dGMpqT41KeWuVpaXTVwErL-suSv8kmAAkzI4WpfOQgHC8m0cjZSzs5jUNXxpnEcXdMUge32gmnk0Qj-xbpwThH9QJ2MTiNg1ABru4cTw9gMwkTQC8rNLSqZ4SE1Acx9r7g_yvCu55XKgAKxDAhxe7kwkjHjcLVgW_cT28WotMqwnApHezzRjnR4gbmlckBck_RwM92Y6gH09slsr8XQGvT2ryzedcggeYN7bR5gU04gbT8b8z_CEowRSQ",
          "widthPx": 2784,
          "heightPx": 1469,
          "authorAttributions": [
            {
              "displayName": "Thierry G",
              "uri": "https://maps.google.com/maps/contrib/116802831696741913804",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXtkwhUP7Owh4NNX6Rd1-R93vTDigv8ddsRdtUFr6u_o3BsRlA=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgIC-6cKtXg&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgIC-6cKtXg!2e10!4m2!3m1!1s0x47f29ddd34a6aaab:0x93dda4c46bdeb8e0"
        },
        {
          "name": "places/ChIJq6qmNN2d8kcR4Ljea8Sk3ZM/photos/AcnlKN2jvqKO3sb5hkrHkvByZekwM7IBnRrQ28YKdXUiu44ukFB6HRfS3O-7R49cA0OWhVaNBqAR7P39vSR9AvdHNyJncKSf1vDH9FQZkkhab4KM2y6UsQLGvKPg70ETJQ2qhi6aCR7dZ4R67TxUc91biNQ9FdSla2TAwk5aiuiChkD-uCERGHhySfF5rF8kpqXKZUapfkN2GCgwyOptdTUvpMXCpNnnU72LU9aXziDw1wWAHnmaU3V8z9Ev_SU96uXJDFJODf-KP2rtygnIBPxRC_1AF2q6lKMxvDPvS6XZ4bTJ6BT_ekYts5IqpPe1m4N5X53wCdIBdPt1lwCY0_jK4a1_NjzWA5Balb0Hzfqg021Or5qIK1r0cPCwD99RTMLCTHxNcoiqVknCiZ_UdXeajpm655Z-lqC2xAVfmYMA3mEMdIjl",
          "widthPx": 3060,
          "heightPx": 4080,
          "authorAttributions": [
            {
              "displayName": "jean-christophe corbet",
              "uri": "https://maps.google.com/maps/contrib/114296298792808830851",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWQjA56zrFMhsO_k6V9NDs9Yr7Q6zdLU1Kx4d-7YhwlCX5mLhQe2A=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgIDVsKaduAE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgIDVsKaduAE!2e10!4m2!3m1!1s0x47f29ddd34a6aaab:0x93dda4c46bdeb8e0"
        },
        {
          "name": "places/ChIJq6qmNN2d8kcR4Ljea8Sk3ZM/photos/AcnlKN14tD6RAo7a3rm6fSxhY-I7CJMVo0fvPawCwf7s2410AHvo17deeiiJVuHej06u1aaOqJivb_EhPF8kRSTjtqxa6mrbfWZ4ZB6EGtV-8TNn7RePsGBk7kYOSpjkTYmtUvxVk9ZHvGEER9DujBBTN0U1AUKVScCq0qfw_ZUEJosdhZn0pSfwYR1PV7GjhlHythnK5YaMCh2Z9PbT_lqv-bqNQ4mXBSQsJUyrBjlf4Ou_D_8e0V1FZzZ-1Ou5sSyy6uGmBXg_qf0BVfTNKoa1XCUz9XdkBpbVf8LuMaac4cQtLeodU2lkYmVagX9g6PGZ-240mUgQUnRNGtmtDOC0iX6zdNAO22ApZm1UVXqGIdHM_I-hRCvp8Ao2C_WtP35m6EDI1MClHWDgjiKmSdf6N9cE-Zug94T_LadIG2v-M7RbYq4",
          "widthPx": 3036,
          "heightPx": 4048,
          "authorAttributions": [
            {
              "displayName": "Rostislav Skripnik",
              "uri": "https://maps.google.com/maps/contrib/108156412246825643795",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjW7WRKOMMIznsz8WLcaTN02buyshmfkzp7BI65_nxqhnCEKDzpM=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgICE4abCywE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgICE4abCywE!2e10!4m2!3m1!1s0x47f29ddd34a6aaab:0x93dda4c46bdeb8e0"
        },
        {
          "name": "places/ChIJq6qmNN2d8kcR4Ljea8Sk3ZM/photos/AcnlKN222xYmBTfccHdzZPUhfTzIM8Rlz-CGS1Qf34azA96G1CaQpiJyfgkIL9YTrXZTvJjVc45mQUvAvT_tJfVdganfhr2ReoPELFa_eZs1wrHJ8t9gnlxP2L7YeKGHfH_9A7UgWfyiOLH8XTjwY0xnc3teZj3gFRQW2YQGOWSTXwUD-nc5lGhdnDjSfmACmJUcmrPqdmIiPuXtchH24i7kOzor0nKH3yGDY8Oh_J4pDDZo87CbHCvAdwt-AnUivTD_MUBVXq4hKJeNGPa52cUuqCPz2kqED5d9mcE4fzDXTNHX0Fl2dza0yp2Z7f8pUkCwnk6jv_JUan1KKqEuoZdJHmPyr9diZhl5v-M6d2L-I3NzhHYgoJBriB4EcoxyTIx1kVsls5nJa2dmyI1kVEwdknq4NqQNSFEzC6kWItX3arWYM_Za",
          "widthPx": 4800,
          "heightPx": 2700,
          "authorAttributions": [
            {
              "displayName": "Sajmir Asllani",
              "uri": "https://maps.google.com/maps/contrib/109465111865361436094",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocIJ6Wpxjkb_T1s71vd0Jp1HdNXupQY9OGLtGsRJ3P5lDF1suw=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgIDc3ZPLhAE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgIDc3ZPLhAE!2e10!4m2!3m1!1s0x47f29ddd34a6aaab:0x93dda4c46bdeb8e0"
        }
      ]
    },
    {
      "formattedAddress": "65 Rue du Bourg, 21000 Dijon, France",
      "rating": 3.2,
      "userRatingCount": 79,
      "displayName": {
        "text": "Franprix",
        "languageCode": "fr"
      },
      "reviews": [
        {
          "name": "places/ChIJw1DBh8id8kcRuLO_Cqs03vY/reviews/ChZDSUhNMG9nS0VJQ0FnTURBOFB1RlpBEAE",
          "relativePublishTimeDescription": "12 months ago",
          "rating": 4,
          "text": {
            "text": "Not the most appealing shop but the staff were all friendly and helpful. Good for a quick pickup of basic stuff.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Not the most appealing shop but the staff were all friendly and helpful. Good for a quick pickup of basic stuff.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Garlicook Bee",
            "uri": "https://www.google.com/maps/contrib/114231343955258228171/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWS8sED9VEZ-aEZBp9822p4lQ90FMcYzurOMutt1uqHtALeisur=s128-c0x00000000-cc-rp-mo-ba4"
          },
          "publishTime": "2025-02-06T12:20:54.721370Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChZDSUhNMG9nS0VJQ0FnTURBOFB1RlpBEAE&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChZDSUhNMG9nS0VJQ0FnTURBOFB1RlpBEAE!2m1!1s0x47f29dc887c150c3:0xf6de34ab0abfb3b8",
          "visitDate": {
            "year": 2025,
            "month": 2
          }
        },
        {
          "name": "places/ChIJw1DBh8id8kcRuLO_Cqs03vY/reviews/ChZDSUhNMG9nS0VJQ0FnSURYcE1makpREAE",
          "relativePublishTimeDescription": "a year ago",
          "rating": 4,
          "text": {
            "text": "Food and stock may be limited but the young cashiers and clerks at the store have been incredibly kind and welcoming.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Food and stock may be limited but the young cashiers and clerks at the store have been incredibly kind and welcoming.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Sie Jardin",
            "uri": "https://www.google.com/maps/contrib/103572212373957682736/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocJpNLVyhioNr8A0GLnlIRAjwaIzR61jdI3x4zOoVVn_BKHRQ2M=s128-c0x00000000-cc-rp-mo-ba4"
          },
          "publishTime": "2024-10-24T11:13:50.613742Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChZDSUhNMG9nS0VJQ0FnSURYcE1makpREAE&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChZDSUhNMG9nS0VJQ0FnSURYcE1makpREAE!2m1!1s0x47f29dc887c150c3:0xf6de34ab0abfb3b8",
          "visitDate": {
            "year": 2024,
            "month": 10
          }
        },
        {
          "name": "places/ChIJw1DBh8id8kcRuLO_Cqs03vY/reviews/ChdDSUhNMG9nS0VJQ0FnSURKM01HN3pnRRAB",
          "relativePublishTimeDescription": "2 years ago",
          "rating": 1,
          "text": {
            "text": "I would give 0 star if I could, rude service, try to kick customers out and it was not even 10 o’clock. I understand the staff want to close early but I don’t think the owner hire you here to be lazy and try to leave early.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "I would give 0 star if I could, rude service, try to kick customers out and it was not even 10 o’clock. I understand the staff want to close early but I don’t think the owner hire you here to be lazy and try to leave early.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Chien-Yu Chen",
            "uri": "https://www.google.com/maps/contrib/115526729950524702309/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXv18wBI5xaOFREE3N2amYG-4SJaZ2dBt8G7eSWQSzH759fevvM=s128-c0x00000000-cc-rp-mo-ba2"
          },
          "publishTime": "2023-07-12T20:13:17.945684Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChdDSUhNMG9nS0VJQ0FnSURKM01HN3pnRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChdDSUhNMG9nS0VJQ0FnSURKM01HN3pnRRAB!2m1!1s0x47f29dc887c150c3:0xf6de34ab0abfb3b8",
          "visitDate": {
            "year": 2023,
            "month": 7
          }
        },
        {
          "name": "places/ChIJw1DBh8id8kcRuLO_Cqs03vY/reviews/ChZDSUhNMG9nS0VJQ0FnSUN1dlkzckl3EAE",
          "relativePublishTimeDescription": "3 years ago",
          "rating": 4,
          "text": {
            "text": "The only option to buy drinks and food after 6PM (18:00 hs) as all Shops and food stores closes at 6pm, specially on weekends. Nice prices and variety of food.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "The only option to buy drinks and food after 6PM (18:00 hs) as all Shops and food stores closes at 6pm, specially on weekends. Nice prices and variety of food.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Cla! M.",
            "uri": "https://www.google.com/maps/contrib/118216033313399989521/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWVZMZBlip8neRK2G2UahAtZYt9A2WLk4gsX7511tPOmyfX9L4O=s128-c0x00000000-cc-rp-mo-ba5"
          },
          "publishTime": "2022-08-04T11:48:53.014554Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChZDSUhNMG9nS0VJQ0FnSUN1dlkzckl3EAE&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChZDSUhNMG9nS0VJQ0FnSUN1dlkzckl3EAE!2m1!1s0x47f29dc887c150c3:0xf6de34ab0abfb3b8",
          "visitDate": {
            "year": 2022,
            "month": 8
          }
        },
        {
          "name": "places/ChIJw1DBh8id8kcRuLO_Cqs03vY/reviews/Ci9DQUlRQUNvZENodHljRjlvT2twaVUyMUxVa3gyVkc1SVRuUmpPRXhoUXpCemQwRRAB",
          "relativePublishTimeDescription": "a month ago",
          "rating": 5,
          "text": {
            "text": "A store with a comprehensive selection and an owner who perfectly understands his customers' needs… With incredibly convenient opening hours, you can always count on them! Fantastic!",
            "languageCode": "en-US"
          },
          "originalText": {
            "text": "Un magasin avec une offre complète et un patron qui sait parfaitement cibler les besoins de sa clientèle ….  Des horaires plus que  confortables on peux toujours compter sur eux !! Formidable",
            "languageCode": "fr"
          },
          "authorAttribution": {
            "displayName": "laure lapaiche",
            "uri": "https://www.google.com/maps/contrib/111597458809423404262/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocKLW_qrLaj5--Ez9QuemDTt1r5MgpUDaJRwoAZ1XDJIPqGTwQ=s128-c0x00000000-cc-rp-mo"
          },
          "publishTime": "2025-12-25T12:45:20.787873768Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2twaVUyMUxVa3gyVkc1SVRuUmpPRXhoUXpCemQwRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2twaVUyMUxVa3gyVkc1SVRuUmpPRXhoUXpCemQwRRAB!2m1!1s0x47f29dc887c150c3:0xf6de34ab0abfb3b8",
          "visitDate": {
            "year": 2025,
            "month": 12
          }
        }
      ],
      "photos": [
        {
          "name": "places/ChIJw1DBh8id8kcRuLO_Cqs03vY/photos/AcnlKN2LKVuoyka56UGDKBR0IinV6jC07H8cKKHS7uxHePEg_6b_ddNHAu29CDqEKjEt7zvoS-21EwD9Hazk3obfo-Y8F7DDehzeA9RsmG6Ihfme9E-kZwG8cLxpPcy-AQO2BUFhEip3p4wVwZDl8b_SNcpIhUwyDDZzIiZbC-3I-keHooM0SRSiGsidkvMAcz_4C-L8fvB0OjfB4Y4zx7RtjLscDkhG_apbvS1yPWg4lRwfepK88PCpQCRha0wJxsrD-Avmvu0QrDuMkgvkWo60sRHa_JmsdjB3HB0x6JMOJHDs-Q",
          "widthPx": 480,
          "heightPx": 270,
          "authorAttributions": [
            {
              "displayName": "Franprix",
              "uri": "https://maps.google.com/maps/contrib/101398462402708972800",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjV5C7hTBagV4geyJjj_tm0xi5r0dTUzvLokraMlKiWdc97KXQ4-=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipNeEzJVVgQxpTTPNg3hd6mjhMiJUUTB5lV8mbUJ&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipNeEzJVVgQxpTTPNg3hd6mjhMiJUUTB5lV8mbUJ!2e10!4m2!3m1!1s0x47f29dc887c150c3:0xf6de34ab0abfb3b8"
        },
        {
          "name": "places/ChIJw1DBh8id8kcRuLO_Cqs03vY/photos/AcnlKN1HXyXIOMRSIeRMq66Y4FoHHWBel5xx54G7L7RHW8zWR0jkZ-rCfJJzFpebmfO8nYyuLhQmBk58SJAnwbmZvJeLuYNSlPL52D0kO2VsjxTy1s26gBmhlbAdWR8_ilV3ddNlWBxdN0Nxu6FqcOcBNjjhAVS5FNgJIZjTg7eHJRwdiUNK_3uZCE2eD86UcxOwgJqWu7QCimizh1tiuyLenc7K9bdCynBc44lLSRa7dRcAL2o7bfD5D626T1Hbh1FwzblZmGIPB0lf7NGT9sjR-uxKF_8c3tIwcy_u45Y5MPcCrQ",
          "widthPx": 720,
          "heightPx": 782,
          "authorAttributions": [
            {
              "displayName": "Franprix",
              "uri": "https://maps.google.com/maps/contrib/101398462402708972800",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjV5C7hTBagV4geyJjj_tm0xi5r0dTUzvLokraMlKiWdc97KXQ4-=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipMDq3LuwFH3Am_KY4uoAq_jf104okj1Trb8mNyD&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipMDq3LuwFH3Am_KY4uoAq_jf104okj1Trb8mNyD!2e10!4m2!3m1!1s0x47f29dc887c150c3:0xf6de34ab0abfb3b8"
        },
        {
          "name": "places/ChIJw1DBh8id8kcRuLO_Cqs03vY/photos/AcnlKN02wCqjNDKX4iQLCLEyzaUaNzhxg0jJGP7_L2jeZa5IUnBNmIC7MnGdl61l08l7oVP0SUWq9OAOW4R4pvIh2zyokjJZ8CuGbSHXfury0aAPUes5L7Yt4E-ifJPOX6c5sf6N55HP1hocTd1B_CIKnu5toc6a34LtFM3mIvmqrh45NqO09Y4Uo_7BBYmlfjcx7Pnn1ewgv5poD6_Ht_JFnIXI4J-NTbaPYnp2c2ohn2Nt4wZDqg3W-N9J-pViJFNX2jrOqMFhuSUBayR5-mX22fHBNQLJOJDuiRrM63mg_4iR4vyTlCQOOWJ4XZ3AYW8V4_qAUX2NM_VE_eFyinuFcAtNpkEvt2aN4UYoCFDK0KOZjDaneJFELYZ5JZiNyxpQvIn52kcwzFvyq29iggGDn0kxTu1r5hBumjRWAfN7usJeOA",
          "widthPx": 1920,
          "heightPx": 1080,
          "authorAttributions": [
            {
              "displayName": "japonaistyle",
              "uri": "https://maps.google.com/maps/contrib/108821915092297113596",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocIbWAbDJfFrDgHKm1nwBrvn_59YJClic3XhSGNY6gjAqbWhJg=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgIC21ML4SQ&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgIC21ML4SQ!2e10!4m2!3m1!1s0x47f29dc887c150c3:0xf6de34ab0abfb3b8"
        },
        {
          "name": "places/ChIJw1DBh8id8kcRuLO_Cqs03vY/photos/AcnlKN20zbbbxL50ImDyVYvIkXJtmmYTMoqGRDMNrEGHAVrHPyIjXj2H6Bp2X2sFwnjDQInRV1wI3nmSDOpOTVyE_DLt93EK3tlhJohFdwqY6SdznT3Co55pTXz7ZDjJ1_1ndwNZ9-O8GhGmoD2EgGwB1JsqAIkLeJDWmO6F-Mv2QtK0SO1VOqU5mZwG36qCyDSfalXN3ZSjLrN8JyDaP0GMeqQH3VIIGXcTi-eT3o3b4Qx6w18KqIzVDU9Crqxb6EvLu8X6Um3dn_6wdF2dgh1ImG2Xm7Yb3UAmVT--cch5iA7Sy-wQnba1iQwNg9Z8vOOE4lr5oQ4TDClrmYbitY3fJv0Lf1F1uYFqCpE62xpHcDEU0YoqxqhhW8LMslbBrNOt1Ov9puxdEal4762SDHT2ke0k2O0MjsdkUACwl_7c0zM",
          "widthPx": 2160,
          "heightPx": 3840,
          "authorAttributions": [
            {
              "displayName": "Peter Ch.",
              "uri": "https://maps.google.com/maps/contrib/111563760282898498201",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWQ4opNrbzT7uupFktV3uR2hN3bAECXayrm_AD4L--ykLJc1ZRSKA=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgMCo95u0KA&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgMCo95u0KA!2e10!4m2!3m1!1s0x47f29dc887c150c3:0xf6de34ab0abfb3b8"
        },
        {
          "name": "places/ChIJw1DBh8id8kcRuLO_Cqs03vY/photos/AcnlKN09HtAD9CfW6xNLXkHU41gcyZ5RecLgQO3Re9bDhAW0c9LriZRlRTIZONTQkz2aCVbMCCNqk2YMNjKNl2dx-2TRfcwyaMYQxq8ABP0IdponkxFg3eN8Pi7eKc7yWUESvffxFrwytZx6rDeiO6f-crK5EnY8nZZFEczB3DVnuL4z_J7pYiBDftHNMB3WxPHZFHuW3RthoFeA8V0lAqm5M98XD_eZqu1n3Mm8uxrptGHn4TsX7Xk4PAqA6YNO545QpD8CKABmieITJCu32srohw3-C3UsvEb4FrQg83QiQ7guyAPduiJImBJtjCOHGlos-Cza1vN3HkxYwmeMSbmFkYmT0zL-T_utbOtVktFiVc8gq6YaTBNQGXdvwGjeKiqTt_J2_sriCHawQt16f2HHs-WwSt_XfqicSYYM9GTp5QvX3don",
          "widthPx": 2160,
          "heightPx": 3840,
          "authorAttributions": [
            {
              "displayName": "Peter Ch.",
              "uri": "https://maps.google.com/maps/contrib/111563760282898498201",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWQ4opNrbzT7uupFktV3uR2hN3bAECXayrm_AD4L--ykLJc1ZRSKA=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgMCo95u08AE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgMCo95u08AE!2e10!4m2!3m1!1s0x47f29dc887c150c3:0xf6de34ab0abfb3b8"
        },
        {
          "name": "places/ChIJw1DBh8id8kcRuLO_Cqs03vY/photos/AcnlKN12-uoBvp3nztOqfOMB5SJuCDh76I2afTfYm8AVSnNUaHzhyyWIN-RRLYDHCDA9LPPOql1Dm0zHpbRbN2D9DHukIvc4L-6cDplwXre-Ct2yZ68QlhwAUOS1AcmCb3rmjFeeLpoiN6aCIptOJt9mDsyokmcP46XKlu5UgQ5NahMz8J-_UhHhfqEUs8p0KhtsNvQGdxa-rxIPwcKHMiooMBipdIlY31sPVraQyVmljFLNu03bRtjWFo7KCHZpg7dwIDQWZcTjkbpPD0HauDXBrChlqxj7VK8laGgBVo4-yu9ad4I75DChPlxI41z0jLR6RYSaw0900ExhPvJYaWjTWlb6kCK_8q6a0_hG4dz9VzHYKtKpb_scixod47p3pru6jEp0xUSvlAgFyk53JPweHfpav18E1x79b06xbPpZGcx6MQ",
          "widthPx": 2160,
          "heightPx": 3840,
          "authorAttributions": [
            {
              "displayName": "Peter Ch.",
              "uri": "https://maps.google.com/maps/contrib/111563760282898498201",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWQ4opNrbzT7uupFktV3uR2hN3bAECXayrm_AD4L--ykLJc1ZRSKA=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgMCo95u0GA&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgMCo95u0GA!2e10!4m2!3m1!1s0x47f29dc887c150c3:0xf6de34ab0abfb3b8"
        },
        {
          "name": "places/ChIJw1DBh8id8kcRuLO_Cqs03vY/photos/AcnlKN1W6WRmObwFbH_XF49gb9yOlGnWHyYdb-MTsHgZIv4Xyxy5mi69gXO8DdAWgllg0cOIdTVLoK_3n83PySDjHcKZKG7QwcE-lAi8Pyp3TAMfJ9qojw618aLLrhMacsXQKOk6JGtKfZG3mCyS6Jw392D4aQsUAT31xsGEOGPYNjxMH3d7SgPOshzADxTVgjxP24mzOKMWqhC3Cs4_1HNmwVtxhA20aB04QH-NXEqKf7U7W32majlHf4rjX0PMuLONQFuOG5CcNgiKwaClvhXRI7fFGj5OiSztxOWeLKQM1sjmTiA1vEbL5MICzqyl-8_Ky7fYzAIMuGKUekU8EfgCtGC3wiPc0e05-OPIvpfWoghhaF5U_WgFP4KabBf1K0BGd7Kp8pfr2sIT1_8WgUspw77ZWtf4YnWtQzrTMaRNf0U",
          "widthPx": 4000,
          "heightPx": 3000,
          "authorAttributions": [
            {
              "displayName": "Eric Finkelstein",
              "uri": "https://maps.google.com/maps/contrib/111444671146808251214",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocJvMTFe-XnhkXFW5VFNZ4ngdUxvt3s3uBD8Mhqr_jMQlLXzZQ=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgID23taBQA&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgID23taBQA!2e10!4m2!3m1!1s0x47f29dc887c150c3:0xf6de34ab0abfb3b8"
        },
        {
          "name": "places/ChIJw1DBh8id8kcRuLO_Cqs03vY/photos/AcnlKN2R03BOZj86BAtSX1CcZC74SpNcZTXT-NYCELoYck9odVspiMpTTmPPl3E0D-Vf2Z0qEPK10J3COigAyZWfjCdZhoSVKM0j7XS5fO4CO8swi45Dnbocgd1K7muAtsPClCM_TYWrKeB8NHZ63aapRrfZZ6BasUHbrgTahm0x5muuapuj7vzvhPTe3c0ezlhS2aXsXrNtZVgH6X9qsswbDVAK2WmPjUgVRzcL_OH_q4UvhWfiQ7qjNV_bh93PT9o2oWxMuJYgjfrhNOX9zzsGCV0pALDY7sXJTIYBhJ-6B1EqCVhdgkkNQlLtpwOdnD2hBybT8pNyWuycehat-P-eT2JprGwIb49iPAK0U__Y7NNh7doGvsg9SeSaTHIfrJg9SVCXd-1qjNQQpnX9MLS3AXWbDtdJHyFE5c8Fxi8HTzflgQ",
          "widthPx": 2160,
          "heightPx": 3840,
          "authorAttributions": [
            {
              "displayName": "Peter Ch.",
              "uri": "https://maps.google.com/maps/contrib/111563760282898498201",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWQ4opNrbzT7uupFktV3uR2hN3bAECXayrm_AD4L--ykLJc1ZRSKA=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgMCo95u0SA&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgMCo95u0SA!2e10!4m2!3m1!1s0x47f29dc887c150c3:0xf6de34ab0abfb3b8"
        },
        {
          "name": "places/ChIJw1DBh8id8kcRuLO_Cqs03vY/photos/AcnlKN24YOL6GvfelscU0DxbzZqyFYOKdBrs0oOJDP3Tka0NDMI_Ys_oE45OCEToC4LDA9V8ANQNire82Gs-wLuXfyIMGN8j2lqjHTmDofiX--zWvO3lZ_gqy_oC-OY2aY69nTj0m37kpCLI8-dSfSCUVXm3hQHo_QD45M6pCpSB_HeRoHnReJYZNJzfJBcPTnf4G6PUs8i_tnz3wn3Ofh_rlSrM11_-RgF_cqR8qlrWQoXqYbwn2xMnJY1tJowjMZ6U9dkSfnGfsnazHvwcsVOAa_gtD7HXQR0Xfx4bhwgxDqp5n3MACXhRzjFUzwprUgLo4SqtDytmhFH1LqslyFtDQavc9YsV0boBrxzW8ZS9_trCs7HfGh_H3sKjpQ6NLCesZsp6wzCOECpru0B2OaPO1iZc_gIxeNBxXD3PsE5OyWoX4K8q6VsiEdqGjjSPhJPX",
          "widthPx": 3024,
          "heightPx": 4032,
          "authorAttributions": [
            {
              "displayName": "floor Martinez",
              "uri": "https://maps.google.com/maps/contrib/106690618579995108143",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVYIN2x5OOxkiHJLZbhTVLNJkvU3dV1QPwOSHp7q2qCpMOHDusTog=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhBsvXhNeV8K90t_t8GDf2To&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhBsvXhNeV8K90t_t8GDf2To!2e10!4m2!3m1!1s0x47f29dc887c150c3:0xf6de34ab0abfb3b8"
        },
        {
          "name": "places/ChIJw1DBh8id8kcRuLO_Cqs03vY/photos/AcnlKN3TuilIVvZsaulX46k2QtvG0QPnpKlQRvPerticM1UGv4bo9_tIs8NKf_6UpxXy0ugi2pa6CJlAdYexzzQZqKAQsq_s2UDwBx7tJTM7-csCMw1eC82DzuUrpYPXAw5Qh1eByV6-KccMPf7lJE7EW-Ay1RVh4_4f7W0ult7hanGrrAR7gRo4ByoJicFLU7OzTnPIVS8TgPjiN3jJW0fybDK53N-wUlkts1Y7OSNuNKlljoFKl_OwPeUMXKvfh4WF6yFqIsnkwykoKxMpkeZ3Dp8tVwZXQWLTukrOL4_8ht1vM_XB99Tfab34Jv1wKxwBkBbKUhmIJ0TFEzIaQhBklErPfao8qyHLuqvk05ej43wk8wc5JLeOAfuwdE9K-eGk9IjdC0zTnQhFiptY_qBpcbH7DjUu0kQRnT_gsIYzbHSTQS0",
          "widthPx": 2160,
          "heightPx": 3840,
          "authorAttributions": [
            {
              "displayName": "Peter Ch.",
              "uri": "https://maps.google.com/maps/contrib/111563760282898498201",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWQ4opNrbzT7uupFktV3uR2hN3bAECXayrm_AD4L--ykLJc1ZRSKA=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEICAgMCo95u06AE&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEICAgMCo95u06AE!2e10!4m2!3m1!1s0x47f29dc887c150c3:0xf6de34ab0abfb3b8"
        }
      ]
    },
    {
      "formattedAddress": "53 Rue Jeannin, 21000 Dijon, France",
      "rating": 4.9,
      "userRatingCount": 465,
      "displayName": {
        "text": "Restaurant Dijon L'évidence",
        "languageCode": "fr"
      },
      "reviews": [
        {
          "name": "places/ChIJY2ctfp-d8kcRufKrOHFqJoA/reviews/Ci9DQUlRQUNvZENodHljRjlvT2t0RVNIbDBVbWhaUTJaUWRuZHBNRWg1U1hWTU5WRRAB",
          "relativePublishTimeDescription": "7 months ago",
          "rating": 5,
          "text": {
            "text": "Amazing dinner experience at affordable price. Staff is very nice and welcoming, highly professional and always paying attention (despite just 2 people welcoming and serving). We had seating downstairs and despite big group next to us, was pleasant atmosphere. Food was excellent (had fish options for both starter and main course) and there was good wine selection. Highly recommend to visit!",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Amazing dinner experience at affordable price. Staff is very nice and welcoming, highly professional and always paying attention (despite just 2 people welcoming and serving). We had seating downstairs and despite big group next to us, was pleasant atmosphere. Food was excellent (had fish options for both starter and main course) and there was good wine selection. Highly recommend to visit!",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Yulia Bless",
            "uri": "https://www.google.com/maps/contrib/117186249466777503172/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocI_lbNBsFR6c-Rnm6fJJL1UH6nLVWwLG30uEyYvEKut9aGaUQ=s128-c0x00000000-cc-rp-mo-ba5"
          },
          "publishTime": "2025-06-11T05:30:13.318134333Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2t0RVNIbDBVbWhaUTJaUWRuZHBNRWg1U1hWTU5WRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2t0RVNIbDBVbWhaUTJaUWRuZHBNRWg1U1hWTU5WRRAB!2m1!1s0x47f29d9f7e2d6763:0x80266a7138abf2b9",
          "visitDate": {
            "year": 2025,
            "month": 6
          }
        },
        {
          "name": "places/ChIJY2ctfp-d8kcRufKrOHFqJoA/reviews/Ci9DQUlRQUNvZENodHljRjlvT2pRd1RXeFRSMGsyVFVaRlptaDNXVkEwYW5kb1EwRRAB",
          "relativePublishTimeDescription": "3 months ago",
          "rating": 5,
          "text": {
            "text": "The food and the level to details is just exceptional for the price we pay, I am not sure if it’s possible to find another restaurant in Dijon matching this level.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "The food and the level to details is just exceptional for the price we pay, I am not sure if it’s possible to find another restaurant in Dijon matching this level.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Chengchen JI",
            "uri": "https://www.google.com/maps/contrib/114899559449426197785/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXAZNiPcdb_gyNxdcwlo9ORMePeZSs__uxNMSpHztobh-KUa8Dz=s128-c0x00000000-cc-rp-mo"
          },
          "publishTime": "2025-10-15T21:21:24.651662628Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT2pRd1RXeFRSMGsyVFVaRlptaDNXVkEwYW5kb1EwRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT2pRd1RXeFRSMGsyVFVaRlptaDNXVkEwYW5kb1EwRRAB!2m1!1s0x47f29d9f7e2d6763:0x80266a7138abf2b9",
          "visitDate": {
            "year": 2025,
            "month": 10
          }
        },
        {
          "name": "places/ChIJY2ctfp-d8kcRufKrOHFqJoA/reviews/ChdDSUhNMG9nS0VJWEZ5ZVd5dXQtU3NnRRAB",
          "relativePublishTimeDescription": "7 months ago",
          "rating": 5,
          "text": {
            "text": "Excellent value for money. Each dish was unique and well-thought. The tomato appetiser was one of the best dishes we've tried! Service was impeccable.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Excellent value for money. Each dish was unique and well-thought. The tomato appetiser was one of the best dishes we've tried! Service was impeccable.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Elisavet Rozaki",
            "uri": "https://www.google.com/maps/contrib/101640566739806023176/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVQ1wAYXeudc9P5Bv3usf9wXr-kw1v9K8mQlwBj7cg8a92n_pbgVg=s128-c0x00000000-cc-rp-mo"
          },
          "publishTime": "2025-06-09T14:29:32.553653Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChdDSUhNMG9nS0VJWEZ5ZVd5dXQtU3NnRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChdDSUhNMG9nS0VJWEZ5ZVd5dXQtU3NnRRAB!2m1!1s0x47f29d9f7e2d6763:0x80266a7138abf2b9",
          "visitDate": {
            "year": 2025,
            "month": 6
          }
        },
        {
          "name": "places/ChIJY2ctfp-d8kcRufKrOHFqJoA/reviews/Ci9DQUlRQUNvZENodHljRjlvT21WdlgyMDBVa2hyTWxWUWJubEZWRkp4ZUhaa1dVRRAB",
          "relativePublishTimeDescription": "3 months ago",
          "rating": 4,
          "text": {
            "text": "Good Food for good value. Lacks a bit the edge. But a good place to go.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "Good Food for good value. Lacks a bit the edge. But a good place to go.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Karine Curtenat",
            "uri": "https://www.google.com/maps/contrib/115462785980982738003/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocIwt7eTv5gXYNOu-vwu_1wuPCpildpUekhoCY8u3rwsoedXeA=s128-c0x00000000-cc-rp-mo-ba5"
          },
          "publishTime": "2025-10-22T16:19:14.084956163Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=Ci9DQUlRQUNvZENodHljRjlvT21WdlgyMDBVa2hyTWxWUWJubEZWRkp4ZUhaa1dVRRAB&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sCi9DQUlRQUNvZENodHljRjlvT21WdlgyMDBVa2hyTWxWUWJubEZWRkp4ZUhaa1dVRRAB!2m1!1s0x47f29d9f7e2d6763:0x80266a7138abf2b9",
          "visitDate": {
            "year": 2025,
            "month": 10
          }
        },
        {
          "name": "places/ChIJY2ctfp-d8kcRufKrOHFqJoA/reviews/ChZDSUhNMG9nS0VJQ0FnSUNieWRQbFFnEAE",
          "relativePublishTimeDescription": "a year ago",
          "rating": 5,
          "text": {
            "text": "A round of applause for the dedicated service at this restaurant. I felt especially welcome here. We were out downstairs and because we arrived upon opening the fan / air con was not on yet - so you could smell a tad bit of damp / humid in the cellar. But wore off quite quickly.\n\nI would recommend the aperitif on the house - tomato purée was something I’d actually pay for. The short bread on the menu (with raspberry / lime cream) was also my favourite. Very refreshing.\n\nCured ham from the menu was a bit too salty for my liking. The veal was very well made - just enough flavouring that you could still taste the tenderness of the meat itself.\n\nCatch of the day was just okay.",
            "languageCode": "en"
          },
          "originalText": {
            "text": "A round of applause for the dedicated service at this restaurant. I felt especially welcome here. We were out downstairs and because we arrived upon opening the fan / air con was not on yet - so you could smell a tad bit of damp / humid in the cellar. But wore off quite quickly.\n\nI would recommend the aperitif on the house - tomato purée was something I’d actually pay for. The short bread on the menu (with raspberry / lime cream) was also my favourite. Very refreshing.\n\nCured ham from the menu was a bit too salty for my liking. The veal was very well made - just enough flavouring that you could still taste the tenderness of the meat itself.\n\nCatch of the day was just okay.",
            "languageCode": "en"
          },
          "authorAttribution": {
            "displayName": "Joanna L",
            "uri": "https://www.google.com/maps/contrib/113472715762188170690/reviews",
            "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocKf7NTiDtJVOSXnMJyKQxtfmyQVhq72mKe-bcu2Wbtm5pKD5g=s128-c0x00000000-cc-rp-mo-ba4"
          },
          "publishTime": "2024-07-28T16:43:01.525422Z",
          "flagContentUri": "https://www.google.com/local/content/rap/report?postId=ChZDSUhNMG9nS0VJQ0FnSUNieWRQbFFnEAE&d=17924085&t=1",
          "googleMapsUri": "https://www.google.com/maps/reviews/data=!4m6!14m5!1m4!2m3!1sChZDSUhNMG9nS0VJQ0FnSUNieWRQbFFnEAE!2m1!1s0x47f29d9f7e2d6763:0x80266a7138abf2b9",
          "visitDate": {
            "year": 2024,
            "month": 7
          }
        }
      ],
      "photos": [
        {
          "name": "places/ChIJY2ctfp-d8kcRufKrOHFqJoA/photos/AcnlKN1MdEKLa-7YBU6mglE1er2HQmB43YWH4k-bMd0xmRXRyXrUMIZR11u0ST43WYSf5sGI5Tk3qtHX_ZpjcgYos8krw0aBcsO-YAopG1DbFOF9XNLFnu9IO_GB_D6o4euRptT3lSab5gVKJzMRRWL6f9P4YRSdktGV-rUVofJxJHA3ZOLfqdsV2qyhBm4Yn62gqfAN22qGZw2Ahkkw1xlZ2_IVVsMN38na_PCPpcgkZIf6LAAwoEUj3b2kvXeVtA3XQdonY68eWqZCYLlM-BrfeC-y8iXl14c6crX1Afy5Cy2tLA",
          "widthPx": 1024,
          "heightPx": 768,
          "authorAttributions": [
            {
              "displayName": "Restaurant Dijon L'évidence",
              "uri": "https://maps.google.com/maps/contrib/107365674618556827262",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWR3huOMkTGfJvW3phvtMm2QZCOGi0pqB7eWV5nxnwwFD-zr0g=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipNX1tFcXkTsI7_RTAfJiDu_hPMDslNJvPieXEur&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipNX1tFcXkTsI7_RTAfJiDu_hPMDslNJvPieXEur!2e10!4m2!3m1!1s0x47f29d9f7e2d6763:0x80266a7138abf2b9"
        },
        {
          "name": "places/ChIJY2ctfp-d8kcRufKrOHFqJoA/photos/AcnlKN2XnNkIPYcDJSy9WYswIRi-t0JQ00Q8QH8ZZJuuOg0lPdMFFGMzIlLcZS-IEN2Bb34TYr79VrZbkthSsbl9SgLph6poWNkJWwxRzMvQOSpe2uP94a2gP6JKkhuI68xVqHFZSRISs4TgSBpQA61v3Eh3VQigPiEHI-e8a_PeVS-57wEoCgpEZ_dWp6OCY9qEzHQ4rnhMqTrKv0EyFLHMgWU7zlDWt3Ca_hIJuBS083isaMwBJ_gaxWCUvQASZ_qWOpPl3lN4tIuxA1StlBjjLUyWXCL31n11GkMf-71RpG64BA",
          "widthPx": 1920,
          "heightPx": 1080,
          "authorAttributions": [
            {
              "displayName": "Restaurant Dijon L'évidence",
              "uri": "https://maps.google.com/maps/contrib/107365674618556827262",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWR3huOMkTGfJvW3phvtMm2QZCOGi0pqB7eWV5nxnwwFD-zr0g=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipMlJkut-1jWrI-h44aXpfF4guWuyim_RB5IA-XF&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipMlJkut-1jWrI-h44aXpfF4guWuyim_RB5IA-XF!2e10!4m2!3m1!1s0x47f29d9f7e2d6763:0x80266a7138abf2b9"
        },
        {
          "name": "places/ChIJY2ctfp-d8kcRufKrOHFqJoA/photos/AcnlKN0OZaNitwPx0HJ23pPTpFZPMouyQq4JKPRLNtdvXFJO2RnoDZ7zcBQ312kL8XpZ_MZNeN_GT_UW724wPRT8BrSapEMp4EvQcFDJQDlsl_JQrCIdHVCgvi0Y3OtL_fIuz5ri4kdWD_B66B6_qDosWFAdLB5ked9LjqdTxzBH4p_gDBvifS2jeAajvecq5wm00y4MxVqt7J3amqtibDCEeHwrQgddlafwAfDkOnGN9h49uHvUvLktP6aCUFofwCBxVnnMMBPQ1uxl9K5YT85VSJDTsnrSJUXOCTfBTJBE0y6ropVYbH7wBb3bcBPg4T4co_fAGplRJRGmzHw6NO2y_juTHqWgI6_W_D15wxwcHlumzNt1YuAHbeO1qGADSQKGWVoMMSTmNNsbYmIDeY-pXcGwGch62ILWDDBKW6i9pQVW0tYPPUGo3nnL7cp2exVh",
          "widthPx": 4624,
          "heightPx": 3468,
          "authorAttributions": [
            {
              "displayName": "Michel Patois",
              "uri": "https://maps.google.com/maps/contrib/112157967237352024293",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjUm7mV8G95i6jAJY0ev6uWUeBjt-C9nAhLrEjGQZNYIzc3ayK0b=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhBHhbZJXUMAJ_0vDX6mqyGe&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhBHhbZJXUMAJ_0vDX6mqyGe!2e10!4m2!3m1!1s0x47f29d9f7e2d6763:0x80266a7138abf2b9"
        },
        {
          "name": "places/ChIJY2ctfp-d8kcRufKrOHFqJoA/photos/AcnlKN2aWYRVWFL2aN0t4aVbocMbbRVIWE6bO8K0Ib6bjO2YMAVmvKifBU82uTssuAr3WmFhzS3iomHdyF6vhATfnhLPdHS_UpeUI06Tp2xC07wb4gC403RI3aDvRGpAKzDdH4vlVGt6pWE4bzwOHFFE4_ZOC8dveJgv6oEJMGM9rLK0jykL3-ZzazYPZkyJMTa4kCcAuEBfF4XlYWy_8bMdpWsHAjrt9y7-ClNYtnnGbE0iqzfPIsXPnG3YfQYrxydL2Rdy8CIfAuTwCo5oabIEWclVwt2vCo2svvkGhz6P7X-6hg",
          "widthPx": 706,
          "heightPx": 396,
          "authorAttributions": [
            {
              "displayName": "Restaurant Dijon L'évidence",
              "uri": "https://maps.google.com/maps/contrib/107365674618556827262",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjWR3huOMkTGfJvW3phvtMm2QZCOGi0pqB7eWV5nxnwwFD-zr0g=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sAF1QipMHKg9EipK6Ps4bbeHv5b9WYvD34rhZ3hnQsIQc&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sAF1QipMHKg9EipK6Ps4bbeHv5b9WYvD34rhZ3hnQsIQc!2e10!4m2!3m1!1s0x47f29d9f7e2d6763:0x80266a7138abf2b9"
        },
        {
          "name": "places/ChIJY2ctfp-d8kcRufKrOHFqJoA/photos/AcnlKN0vcmclm4knIDbgIudxwdVpqad5ie5dQmcdf20y3uErteSKuk43OgwssxLPUbif7jrYPvwE1EZYk9M3VkUnN1MUvFsMQE-pbez5wUxRJolFpYImo_qk6f3UJkCCFqugb0h8afLLQ9GYl481D83dAHuAJvOP7b0OePNMDUGoI2c35yNxCrfeTlJI9GEKCTo4fkTMaUFuTpLOKyHCI2hxrxv_GOZbIUHU4XuzdiL5QgZwFEuHLoRbq9bNdriKsWpEiuT_8GvkaF4m9csUwsc6C1NOMcBNj4POWdCiU-X9yV5i6VW60EnPsjGnzvXYLpVilv5QxE1Azro0F6HpjbQlAIIWizAqK6XvfxB4tHIO3j1BvxcnfODQEuKCza6_W-N7QU_4UhTsNV9ECAzOD44FSwMaH_hzslWGoEffp7olXr5m3A",
          "widthPx": 2268,
          "heightPx": 3287,
          "authorAttributions": [
            {
              "displayName": "Elisavet Rozaki",
              "uri": "https://maps.google.com/maps/contrib/101640566739806023176",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjVQ1wAYXeudc9P5Bv3usf9wXr-kw1v9K8mQlwBj7cg8a92n_pbgVg=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIHM0ogKEPvrv8P9gPDEaw&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIHM0ogKEPvrv8P9gPDEaw!2e10!4m2!3m1!1s0x47f29d9f7e2d6763:0x80266a7138abf2b9"
        },
        {
          "name": "places/ChIJY2ctfp-d8kcRufKrOHFqJoA/photos/AcnlKN2fNGLdeaiWGIWHKttsk1-DC-4kpklOCLXvrd65L7FnfMyZuX8WPpYW0gyOX_cDZrGQUM7bSl4-RLdyGRxqtv54Aafy0nJKbKJa0ALcTe7n0Ni6MkVYFGd7eKZVFClNQYmXvoV68mdMrzgE2uJCxwc382dPrmZD0gf2m5_SiLxfAfw04nf1cHifnlyoX4QAPty3RrpZMD60G3EjoblW0KDWLDV0BLN4dep_doY-vwDfPmTLOKwRBEppWYrI-YDojcVpj85MZp1_0lie0w3NhaLLl62M32vPn9RkfisgRhQMPkn6eQwpTu0_caFL2bojEmtIvm39KfpENP5Mhtj4GCVU7dSejcTgtHSgwL7oU3x0We4r3GnjrowqbW0wN8b8oLS7q2JPvWqWXlaARcitgoAHgmzXQXy-TXOHMksVfLgDO1uyM7v4vPO0XgiGnQ",
          "widthPx": 4800,
          "heightPx": 3600,
          "authorAttributions": [
            {
              "displayName": "Chengchen JI",
              "uri": "https://maps.google.com/maps/contrib/114899559449426197785",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXAZNiPcdb_gyNxdcwlo9ORMePeZSs__uxNMSpHztobh-KUa8Dz=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhAt5peaOPdnM_1ZsEaxvceT&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhAt5peaOPdnM_1ZsEaxvceT!2e10!4m2!3m1!1s0x47f29d9f7e2d6763:0x80266a7138abf2b9"
        },
        {
          "name": "places/ChIJY2ctfp-d8kcRufKrOHFqJoA/photos/AcnlKN1bINouTWKqE3U-EA4y2Aejn-OSv_qMhOBvzVJdeUUrjm8-ZcnmeyZOsoNS7Bt8hydnYCsIb3y5A9IUTsodeFUwkeY4GFTNyVCgT7KVQnyj5np9ChyTuOeC3sq0zRuin4oWi5YZJJVVMJK5DTYeoiTzUD4i1jA0eb_hk1Ma04TInugxc4YHS_-bDhJyqjTNxnq7mSTQjD-nzYz1c3kkOTtdxniWcYV3kOIse5BUZ9sOFQdElThOyLhbigHZhT0biOHPS2iY_L24PqWyA4TP2hTAgH2TEMS5suMsXhuO5tutJGNxUZ2DNqVkJuAn-n2sFNTcRPLLvnc1Ccu13qyK3vVhV9OZACcW_KNYpFc-_7e44dYOJ0s2Fx4iK1jD3QdPNC4nCTzxHJ7MueyMyGeZ0RoNt20Lemvc0adV1w5u4n98XBzEDfm6EhbDoZIYv_Ph",
          "widthPx": 4032,
          "heightPx": 3024,
          "authorAttributions": [
            {
              "displayName": "Yulia Bless",
              "uri": "https://maps.google.com/maps/contrib/117186249466777503172",
              "photoUri": "https://lh3.googleusercontent.com/a/ACg8ocI_lbNBsFR6c-Rnm6fJJL1UH6nLVWwLG30uEyYvEKut9aGaUQ=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhAxx6_ziBcQQUTEyO-2aK3r&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhAxx6_ziBcQQUTEyO-2aK3r!2e10!4m2!3m1!1s0x47f29d9f7e2d6763:0x80266a7138abf2b9"
        },
        {
          "name": "places/ChIJY2ctfp-d8kcRufKrOHFqJoA/photos/AcnlKN2U23rEHgrHaT8_G4f1gVn0h7DKNjDqYeWqlIMijMUAQtJPYrHXnfykQAbIMmzO0DE9MDUcfhOUJgG5c0AxjwWEKWovKHDMkwPUKwIGHGr2d7qBK4FZaPcenXSCxfhnJ8peYvtmmxYvEORIYH6plFJf2Ema8y_ALoEISzxYInfRU_UkGkXntz46XjWLh0yC5HTN2wU4BXYBgvbF81qhpezZj8bSjF3eSjGcgsB29ePp0TgAUa4XRIgUN_gkWqsusttJbejkj7fG0728Jmy4tse-ywN8aSNRLPVkjqxqpWdi7D2gSOJGgDWEM8PlTeHaUO5NmSfGyNw6TFUMqwA8QkgjA54PelzV1mTIDs4HF0qYXrPkNtILPFsBCYE6r6-8FjLx3aFalt0Tus45Yj1WF9j5TLMxoz7Lq3fZLZqFvH-rqFqEFHdiCCamEGTXVoQN",
          "widthPx": 1170,
          "heightPx": 1526,
          "authorAttributions": [
            {
              "displayName": "JIN",
              "uri": "https://maps.google.com/maps/contrib/108475965913835546318",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjU091MSwmeLlhEaWA8L4RXpdZzBfXuZWf6WrIfrsW3hywAcT6VP=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhD11fQqm0KBY-A5uVU07pxj&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhD11fQqm0KBY-A5uVU07pxj!2e10!4m2!3m1!1s0x47f29d9f7e2d6763:0x80266a7138abf2b9"
        },
        {
          "name": "places/ChIJY2ctfp-d8kcRufKrOHFqJoA/photos/AcnlKN1t9lXxnKU2LKTisxtwma1uSl-zmIz8rE4vPvecARcKDIUTYNS99FThYaNXmB4b43-HRw_u4IEz03lRpWrpbGCDS_1x0Wq64vpK-NY1ETRBhTGuXP85dcbqdegMRbolW1y5feLA7phQX2wykvzYRAkhcm7WAR15W1O9JuyUMIPWbLZlOKChRzUQboWLghRC51rgxdvtv3XHCMmtUQumODptfKBMZ16c_HlIdbVG708K5PNLsMCNGfetF0F2RzF7NDeIxCBPQYTNVRTgehZaLbZz2EuUqMYymgr6kYprHeMChab5KpSir4eYAKNuWhU8QvZxMh8_y0qeFXULefWGbUFEldJ7Bk30ON5stf3SIIGoKDL71JVOz4xxROQRU2xv-BLDcXXJfPRYlwKxhqsdEJCckZ3dOT9y7lgKz8U1yocSX9nKJNC_bX6EHbF-roMt",
          "widthPx": 4800,
          "heightPx": 3600,
          "authorAttributions": [
            {
              "displayName": "Chengchen JI",
              "uri": "https://maps.google.com/maps/contrib/114899559449426197785",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjXAZNiPcdb_gyNxdcwlo9ORMePeZSs__uxNMSpHztobh-KUa8Dz=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhA9kfYyB2qYIzH0PwQTtqs2&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhA9kfYyB2qYIzH0PwQTtqs2!2e10!4m2!3m1!1s0x47f29d9f7e2d6763:0x80266a7138abf2b9"
        },
        {
          "name": "places/ChIJY2ctfp-d8kcRufKrOHFqJoA/photos/AcnlKN0ogIvdAanPcI70-0MGKrLfsoUq-r-AEgULqmv2a6_R0fAkrsGtv9HsWNqWDCtKETnftmeLZkYTefaNM2RAAEhZcqHE99KlKodB5zd6vPPyxlIQ5tCe1mqv8NRAto3JGo1fQyWkqZBkSmkC09j747B8scnsbCNzu-1gf3QT35-hvRuVH_7_zXK_qocK5VZuNu6DUYl4IhA3XdKut8V8-srwqaGkcvbtmKWEbXiFbgR1GeWsGRMt8gTmicbF6Od0v1RBSase5C1SbYY_YpIBWwexbbBFQwaKe9r8mpdwaTsSO1knbFwhw4tWBuc8-7wH81VA4TKmRL2xqH3sP7SqRCtLVcPfrF2fynWzh1SKVyZJr8QURP76a2DjBH79J-RA8tj1gWAZe7OD4VatniYP7hGZA2Ccvw1Qg2oqE6nV_Nc6pKci1_rJv8IZsVNJUg",
          "widthPx": 1170,
          "heightPx": 1493,
          "authorAttributions": [
            {
              "displayName": "JIN",
              "uri": "https://maps.google.com/maps/contrib/108475965913835546318",
              "photoUri": "https://lh3.googleusercontent.com/a-/ALV-UjU091MSwmeLlhEaWA8L4RXpdZzBfXuZWf6WrIfrsW3hywAcT6VP=s100-p-k-no-mo"
            }
          ],
          "flagContentUri": "https://www.google.com/local/imagery/report/?cb_client=maps_api_places.places_api&image_key=!1e10!2sCIABIhAy04otfcOcxDcCnhvCGf2L&hl=en-US",
          "googleMapsUri": "https://www.google.com/maps/place//data=!3m4!1e2!3m2!1sCIABIhAy04otfcOcxDcCnhvCGf2L!2e10!4m2!3m1!1s0x47f29d9f7e2d6763:0x80266a7138abf2b9"
        }
      ]
    }
  ]
}

""";
}
