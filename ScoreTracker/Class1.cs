using System;
using System.Collections.Generic;
using System.Text;


class ScoreTracker
{
    public const int maxScore = 100;
    public const int minScore = 0;
    public readonly string subjectName;
    private int score = 0;
    private int bounsCount = 0;

    public ScoreTracker(string name)
    {
        subjectName = name;
    }

    public void SetScore(int score)
    {
        if (score < 0 || score > 100)
        {
            Console.WriteLine("점수는 0~100 사이여야 합니다.");
        }
        else
        {
            Console.WriteLine($"점수를 {score}점으로 설정했습니다.");
            this.score = score;
        }
    }

    public void AddBonus(int bonus)
    {
        score += bonus;
        bounsCount++;
        if (score > maxScore)
        {
            score = maxScore;
            Console.WriteLine($"{bonus}점 보너스 적용! 현재 점수: {score}점 (최대 점수 도달)");
        }
        else
        {
            Console.WriteLine($"{bonus}점 보너스 적용! 현재 점수: {score}점");

        }
    }

    public void ShowScore()
    {
        Console.WriteLine($"=== {subjectName} ===");
        Console.WriteLine($"점수: {score}/{maxScore}");
        Console.WriteLine($"보너스 적용 횟수: {bounsCount}");
    }
}

