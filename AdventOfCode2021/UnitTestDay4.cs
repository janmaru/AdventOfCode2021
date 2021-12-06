﻿using AdventOfCode2021.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AdventOfCode2021
{
    [TestClass]
    public class UnitTestDay4
    {
        [TestMethod]
        public void Day4_ShouldGiveOutTheRightBingo_True()
        {
            var demo =
@"7,4,9,5,11,17,23,2,0,14,21,24,10,16,13,6,15,25,12,22,18,20,8,19,3,26,1

22 13 17 11  0
 8  2 23  4 24
21  9 14 16  7
 6 10  3 18  5
 1 12 20 15 19

 3 15  0  2 22
 9 18 13 17  5
19  8  7 25 23
20 11 10 24  4
14 21 16 12  6

14 21 17 24  4
10 16 15  9 19
18  8 23 26 20
22 11 13  6  5
 2  0 12  3  7
";
            var inputs = FileHelper.Read(demo).ToList();
            var day = new Day4();
            day.Parse(inputs);
            var res = day.Board();
            var b = day.Bingo(res);
            Assert.IsTrue(b == 4512);
        }

        [TestMethod]
        public void Day4_ShouldGiveOutTheSolution_True()
        {
            var demo =
    @"18,99,39,89,0,40,52,72,61,77,69,51,30,83,20,65,93,88,29,22,14,82,53,41,76,79,46,78,56,57,24,36,38,11,50,1,19,26,70,4,54,3,84,33,15,21,9,58,64,85,10,66,17,43,31,27,2,5,95,96,16,97,12,34,74,67,86,23,49,8,59,45,68,91,25,48,13,28,81,94,92,42,7,37,75,32,6,60,63,35,62,98,90,47,87,73,44,71,55,80

12 79 33 36 97
82 38 77 61 84
55 74 21 65 39
54 56 95 50  2
45 68 31 94 14

95 26 80 25 62
79 91 70 76 61
98 97 17 75 23
71 30 21 52 29
20 54 32 12 31

35 31 86 36 52
18 50 79 60 67
98  3 51 46 25
 4 61 55 87 70
94 39 68 27 14

 9 49 53 52  2
65 92  4 73 67
90 95 39 78 64
17 27 13 60 51
25 63 70 77 22

33 34  6 58 77
44 75 54 18 21
15 25 79 12 70
90 14 81 22 49
72 38 59 78 16

13 51 94 40 56
 6 99  9 64 91
87 73 93 71 31
39 42 28 24  7
 1 52 17 85 11

95 23 15 29 12
40 79  2 64 59
94 93  3 25 10
 5 58  7 78 82
62 73 74 16 56

17 55 56 14 51
70 94 66 21 37
97 90 43 80 89
50 12 52 46 85
16 79 60 15 45

18 59 37 25 41
51 61 63  7 53
 3 21 31 76 72
29 99 34  6 83
55 45 93 75 15

59 63  4 95 68
18 47 43 15 26
66  7 54 22  8
50 75 91 20 98
49 61 55 12  1

96 74 37 12 66
10 94  7 29 75
20 48 26 67 41
40 99  9 80 35
72 87 82 76 85

60 58 43 17 57
25 33 85 91 27
46 36 54 49 64
86 53  4 63 95
38 74 84 37 67

66 90 73 98 51
11 94 60 92 14
82 58 17 63 52
33  1 18 77 72
12 76 20 23 10

28 69 67  6 32
 4 17 77 52 33
26 57 92 56 73
30 91 50 82  2
21 31 61 78 99

98 63 26 81 75
23 36  3 88 65
69 87 33 20 43
 4 51 47 70 50
10 91 74 77 66

61 47 90 22 63
26 15 41  8 73
71 40 82 91 75
39 95 56 84 55
 5 76 32 69 34

78 77  1 57 39
70 49 83 90 87
97 74 26 67 19
50 21  2 92 60
82 65 62 31 33

 6 46 97 50  2
48 23 34 24 93
83  7 31 59 66
44 18 21 47 77
69 86 35 72 17

78 68 69  4 26
47 38 15 95 53
66 46 49 79 59
82 30 50  7  2
17 16 34 64 51

19 20 13 75 26
63 28 14 93 50
27 70 61 29 67
12 89 71 33 98
31 25 16 79 69

95 23 83 86 16
 4 50 27 92 62
42 29 75 88 49
31 58 39 44 93
80 19 15 97 96

91 60  6 47 63
51 90 36 11 72
73 84 50 76 40
49 75 82  9 35
71  1  0 67 59

48 56 80 24 86
 4 74 95 53 41
52 58 36 19 64
90 87 99 82 25
35 13 22 26 21

68 87 18 23 97
69 25 40 76 24
34 33 56 16 51
49 77 88 75 26
 2 19 96 35 86

29 26 56 49 10
89 91 95  5 69
52  1 99 34 20
 8 74 64 32 61
25 72 60 22 97

39 65  0 91 86
 9  7 21 62 89
22 92 63 46 17
61 66 37 59 52
93 70  3 97 49

29  3 66  4 43
46 25  7 62 54
71 26 70 75  5
17 82 33 51 19
65 40 91 53 15

88 59 14 41 92
83 74 73 65 12
95 97 35 47 55
62  2  3  9 63
52 44 32 33 72

82 12 77 25 60
 8 93 38 56 97
59  5 70 33 40
 9 90  1 41 57
68 73 26 91  6

72 15 64 59 49
26 12  9 97 80
84 18 91 20 87
69 34 14 65 40
98 74 27  5 31

55 99 23 12 76
57 92 71 83 53
19 24 39 97 73
96 91 32 34 28
 0 72 42 65  1

84 50 97 46 99
90  1 95 64 22
45 53 55 25 42
30 70 52 88 72
29 44 98 51  6

70 74 85 78 45
34 91 82 63 99
17  3 50 53 87
38 88 98  6 92
39 30 10 18 67

26 45 13 93 29
18 51 66 22 17
55 75 70  9  6
 3 74 30 42 91
21 77 57 37 90

17 94 74 85 60
 2 67 97 19 11
20 32 58 18 56
10 95 40 51 93
66 50 15 65 52

 7 38 79 77 42
15 34 13 80 93
46 54 74 33 17
 1  4 83 68 35
70 85 66 63 39

22 68 41  2 58
69 76 14 62 33
64 39 46 28 59
60 21 26 13 74
12 54 99 82  0

 9  0 82  4 20
88 76 18 55 44
10 53 74 93 58
49 50 16 42  2
19 23 66 54 65

96  9 42 30 67
 3 29 94  5 45
65 62 25 59 17
21 79 73 44 66
38  6 86  7  4

89 77 17 13 79
51 10 28 18 36
59 69 80 61 25
 0 21  9 91 30
86 96  2 29 39

53 11 27 20 82
15 38 90 34 98
69 28 16 14 99
67 49 48 42 59
51  2 61 23  3

37 60 14 43 49
66 24 54 96 58
73 28 48  3 81
93 35 97 46 52
75 84 79  1 11

48 75  8 88 85
81 94  3 32 28
63 49 78 86 90
67 84  5  4 52
57 89 29 96 71

 3 34 89 15 64
47 31 57 72 26
48 75 19  2 65
42 45 97 54 71
55 27 87 77 35

74 50 53 19 96
95 89 71 75 26
 8 11 20 43 38
78 51 28 65 93
64  9 84 31 23

37 42 65 94 92
69 35 40  1 71
63 43 75 59 74
97 90 67 91 85
28 58 21 49 52

20 62 44 96 74
18 37 63 54 51
39 90  1  4 84
 7 72 57 19 79
99 66 43 38 36

 2 68 67 21 78
81 86 63 13 69
74 29 53 56 30
16 72  7 54  1
64 50 73 14 45

21 47 88 28 32
 7 43 83 39 27
95  9 98 45 99
68 49 94 73 35
10 36 13 25 37

45  2 16 75  9
66 46 20 91 87
36 74 64 85 62
51 39 93  3 57
 0 37 56 27 50

 9 21 37 96 89
66  4 16  3 56
58 32 97 76 47
 7 59 13  0 34
69 68 95 61 51

30 41 60 88 98
33 94 57 79 40
14 36 17 56 99
10 37 62 54  0
65 32 58 21 23

89 47 65 40 18
25 17 13  0 33
49 57 26  3 76
15 71 70 95 61
67 94 80 77  7

92 40 55 95  8
88 62  4 43 13
54  1 19 20 87
11 97 23 27 80
63 10 66 45  7

46 76 10 61 26
86 55 15 84 25
12 80 82 83 54
22 81 69 70 48
53 89 30 44 20

84 62 57 74 30
96 18 24  9 29
22  8 56 44  4
71 85 16 55 73
25 28 88 61 33

60 26 72 28 89
51 94 24 96 53
39  0 90 12 22
92 95 65 34 32
63 36 48 58 52

92  5 32 52 30
 6 93 73 74 10
38 62 55 28 79
88 60 27  7 83
82 53 39 70 95

84 35 58  4 19
80 96 53 45  7
31 52 14  8 63
87 41 75 65 18
 3 72 79 91 86

16 19 42 49  0
34 18 26 70 98
45 38 87 17 54
84 51  7 24 66
57 46  3 36 43

36 13 44 81 48
93 88 41 77 57
 6 64  2  3 46
30 10  8 20 14
26 76  7  1 90

67 74 39 25 78
 4 96 62 70 30
22 41 72 47 32
87 27 77 51 86
65 35 26 11 85

94 42 49 91 12
78 51  3 95 76
 0 72 13 30 25
33 81 32 58 62
67  5 88 26  1

71 21 29 73 75
39 77 63 66 36
74 18 80 35 34
26  5 53 33  6
19  1 27 25  9

72 53 57 24 30
66 84 68 40 12
52 48 34 21 26
73  3 18 81 67
82  7 17 36 56

93 85 42 81 30
47  4 48 82 96
28 41 52  0 36
97 14 35  9 33
98 11 69 20 87

46 67 85 96 34
90 92 68 56 51
16 61 29 28 27
81 57 64 53 26
 6 49 43 41 65

37 82 55 88 27
43 79 25  5 50
92 83 81 44 22
75 74 39 16 41
48 29 80 77 90

57 25 10 61 40
 1 22 20 81 41
32 83 43 54 97
29 47 15 27  8
79 28 63 77 99

62 43 94 24 48
45 93 14 34 11
58 31 33 71 97
10 59 76 30 26
64 54 79 80 56

34  8 49 13 12
54 57  4 82 46
84 32 59 55 40
 0 73 99 38 56
16 61 36 17 78

 7 97 37 81 91
 3 10 83 48 90
49 40 72  6  2
17 39 94 82 66
58 68 52 64 42

30 93 40 75 74
62 48 47  3 59
57 10 73 79 86
71 89 88  5 38
13  6 56 80 81

58 54 52 83 88
12 84 87 28 46
42  6 27 39  4
47 72 93 64 66
79 71 44 18  3

60 72 89 35 17
77 66 68 59  9
 2 43 18 14 33
20 30 82 31 52
81 64 56 45 27

64  9 44 23 99
40 75 55 29 86
94 46 45 84 97
92 25 30 13 10
90 87 61 53 70

 6 49 41 40 37
65 24 47 33 55
51  4 72 16 85
56  5 25 98 14
32 26 50 17 34

24 78 72 40 31
 3 12 33 87 71
99 91  8 59 34
50 90 63 45 29
75 96  7 22 44

81 94 61 41 10
23  5 66 27 70
62 82  4 74 52
19 55 67 59 49
48 77 35 33 45

 7 86 81 93 19
90 57 64 45 36
75 13  2 28 39
46 10 83 80 47
 1 91 94 24 56

20 18  0 49 44
77 72 31 61 46
66 95 73  8 76
 3 13 99 94 96
59 97 43 85 86

34 78 54 37  0
12 85 86 93 70
53 10 59  8 55
63 20 29 36 32
76 75 43 96 61

62 55 26 17 74
10 15 47 38 20
41 66 59 58  9
34 52 40 93 82
45 43 21 11 24

85 90 47 75 50
51 12  8 54 11
73 19  3 37 28
25 24 84 67 87
44 94  6 20 45

36 99 81 96 75
89 90 29 33 55
40 25 10 32 92
51 27 70  0 15
76 50 44 22 24

31 63 21 13 24
42 87 53  5 38
 8 50 30 73 83
95 91 15 41 52
23 99 10 67 60

88 49  2  4 85
22 25  6 30 62
34 53 74 96 64
77 80 93 65 63
37 27 26 68 56

86 90 40 79  7
57  2 34 91 35
85 74 52 97 93
63 32 38  1 12
29 46 56 84 25

38 26 22 49 24
56 84  2 18 62
 3 90 17 73 37
55 95 92 35 29
 7 51 42  5 39

14  0 19 53 69
 2 22 65 78 31
43 88 37 93 46
12 30 83 26 29
92 68 62  7 44

38 65 61 93 36
53 43 11 12 54
97 99 48 24 21
84 33  3 23 31
56  4 87 90  7

 0 61 67 13 56
24 69 94 85 73
78 35 89 55 72
21  4 90 80 83
64 99  5 16 36

55 72  7 83 35
63 73 96 21 75
 8 79 59 62 37
15 89 28 80 82
34 61 97 23  0

48 21 43 36 15
97 65 91  6 83
84 64 98 31 90
72 58  5 70 92
52 71 25 41 51

14 32 70  8 73
71 75 95 29 68
22 27 65  7 78
21 37 47 19  6
60 83  2 80 98

59 90 57 29 68
54 31 13 61 28
65 37 17 53  1
25 38 20 46 69
23 18 77 98 96

20 38 79 65 16
93 77 14 97 47
34 42  8 18 54
91 64  0 58 75
25 67 37  6 56

88 81  6  8 65
30 51 95 12 97
70 16 55 54 73
75 64 93  1 52
82 77 24 50 36

41 59 17 76 95
51 58 61 73 56
 1  5 53 20 21
22 14 37 28  0
43 35 26 96 32

17 86 68 23 20
41 88 75 58 64
94 90  3  0 26
30 51 13 95 10
97 77 83 57 21";
            var inputs = FileHelper.Read(demo).ToList();
            var day = new Day4();
            day.Parse(inputs);
            var res = day.Board();
            var b = day.Bingo(res);
            Assert.IsTrue(b == 25023);
        }
    }
}
