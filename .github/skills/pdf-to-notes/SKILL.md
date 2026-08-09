---
name: pdf-to-notes
description: >-
  Convert a DSA/lecture PDF into a well-maintained, short Markdown note. Use when
  the user points to a PDF (e.g. a Scaler problem-solving session or lecture) and
  asks to turn it into notes. Extracts every topic, question, hint, and sample
  code from the PDF with no information lost and no filler added.
---

# PDF → Markdown Notes

Convert a PDF into a concise, complete `.md` note. Goal: **lose no information from
the PDF, add no filler.** To the point, no garbage.

## When to use

The user references a PDF and wants notes/`.md` created from it — for example the
files under `scaler/dsa/**/pdfs/` or
`scaler/dsa/problem-solving-session/01-intermideate-pdf/`.

## Reference example

Match the style of
[scaler/dsa/01 - array/01-array-notes.md](../../../scaler/dsa/01%20-%20array/01-array-notes.md)
(the intermediate array notes). Follow the repo rules in
[README.md](../../../README.md).

## Steps

1. **Read the PDF.** Read the full PDF the user pointed to. If a folder is given,
   process each PDF into its own `.md` (or one file per session, mirroring the
   existing naming like `01-...md`, `02-...md`).
2. **Extract everything, invent nothing.** Pull out only what the PDF contains:
   properties/definitions, every question, every approach, hints, complexity, and
   any code. Do not add topics, opinions, or padding not present in the PDF.
3. **Handle partial content faithfully:**
   - Question **with** a solution → write the question, the approach(es), and the
     sample code shown.
   - Question **with only a hint** → write the question and the hint only. Do not
     fabricate a solution.
   - Question with **no** solution and **no** hint → write only the question.
4. **Write the note** next to the source (same folder as the PDF, or the matching
   topic folder) using the format below.

## Output format

Follow the reference note exactly:

- `#` title = the PDF/session title.
- `## 📌` for a short properties/definitions section (only if the PDF has one).
- `## ✅ Question N: <exact question statement>` for each question.
- `### 💡 Solution:` with numbered approaches (Brute Force → Optimized), each with
  **Time Complexity** and **Space Complexity** when the PDF states or implies them.
- ` ```csharp ` fenced blocks for code. Use C# unless the PDF uses another language.
- A summary comparison table when the PDF compares multiple approaches.
- `---` separators between major sections.

## Rules (from README.md)

- Consistent section/question/code format across all notes.
- No built-in helpers (`Sort`, `Distinct`, `LINQ`, etc.) in code unless the
  question allows it — implement logic manually with loops and basic structures.
- Always end each solution with time and space complexity.
- Show both brute-force and optimized approaches when the PDF presents them; write
  code for every approach mentioned, and state which is better and why.
- Clear variable names; a comment only where the code can't show intent on its own.
- Prefer iterative over recursive unless the question requires recursion.
- Mention edge cases when the PDF raises them.

## Do / Don't

- **Do** keep it short and complete — every fact from the PDF, nothing more.
- **Don't** add motivational text, restated theory, or "extra information" not in
  the PDF.
- **Don't** guess a solution the PDF didn't provide.
