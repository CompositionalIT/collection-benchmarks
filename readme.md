| Method            | N      | Mean         | Error      | StdDev     |
|------------------ |------- |-------------:|-----------:|-----------:|
| WithSeq           | 1000   |     5.159 us |  0.0989 us |  0.1099 us |
| WithArray         | 1000   |     3.403 us |  0.0622 us |  0.0949 us |
| WithList          | 1000   |     5.023 us |  0.1002 us |  0.1756 us |
| WithResize        | 1000   |     1.354 us |  0.0233 us |  0.0218 us |
| WithResizeToArray | 1000   |     1.500 us |  0.0290 us |  0.0477 us |
| WithSeq           | 10000  |    51.506 us |  1.0205 us |  0.9047 us |
| WithArray         | 10000  |    32.344 us |  0.5908 us |  0.6321 us |
| WithList          | 10000  |    58.071 us |  1.1499 us |  2.4004 us |
| WithResize        | 10000  |    14.215 us |  0.2297 us |  0.1919 us |
| WithResizeToArray | 10000  |    16.398 us |  0.3189 us |  0.4573 us |
| WithSeq           | 100000 |   512.847 us |  7.3628 us |  6.8872 us |
| WithArray         | 100000 |   403.480 us |  7.8205 us |  8.6925 us |
| WithList          | 100000 | 1,110.814 us | 21.9439 us | 42.8000 us |
| WithResize        | 100000 |   315.082 us |  5.8047 us |  5.7010 us |
| WithResizeToArray | 100000 |   228.140 us |  3.9965 us |  3.7383 us |