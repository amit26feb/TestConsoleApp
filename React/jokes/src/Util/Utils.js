import jokesData from "../Jokes/JokesData";

export const setData = () => {
  localStorage.setItem("joke", JSON.stringify(jokesData));
};

export const getData = () => {
  try {
    return JSON.parse(localStorage.joke);
  } catch (e) {
    return [];
  }
};

export const addJoke = punchLine => {
  try {
    const jokeArray = JSON.parse(localStorage.joke);
    jokeArray.push({
      id: 8,
      question: "Am I a joke?",
      punchLine
    });
    localStorage.setItem("joke", JSON.stringify(jokeArray));
  } catch (e) {
    return [];
  }
};
